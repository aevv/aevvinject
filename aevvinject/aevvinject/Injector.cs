using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace aevvinject
{
    class Injector
    {
        #region pinvokes
        #region pinvoke flags
        [Flags]
        public enum AllocationType
        {
            Commit = 0x1000,
            Reserve = 0x2000,
            Decommit = 0x4000,
            Release = 0x8000,
            Reset = 0x80000,
            Physical = 0x400000,
            TopDown = 0x100000,
            WriteWatch = 0x200000,
            LargePages = 0x20000000
        }

        [Flags]
        public enum MemoryProtection
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            GuardModifierflag = 0x100,
            NoCacheModifierflag = 0x200,
            WriteCombineModifierflag = 0x400
        }

        [Flags]
        public enum FreeType
        {
            Decommit = 0x4000,
            Release = 0x8000,
        }
        #endregion
        #region pinvoke structs
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct STARTUPINFO
        {
            public Int32 cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public Int32 dwX;
            public Int32 dwY;
            public Int32 dwXSize;
            public Int32 dwYSize;
            public Int32 dwXCountChars;
            public Int32 dwYCountChars;
            public Int32 dwFillAttribute;
            public Int32 dwFlags;
            public Int16 wShowWindow;
            public Int16 cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public int bInheritHandle;
        }
        #endregion
        [DllImport("kernel32.dll")]
        static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint wCreationFlags, out uint lpThreadId);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);
        [DllImport("kernel32.dll")]
        static extern bool GetExitCodeThread(IntPtr hThread, out uint lpExitCode);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress,
           int dwSize, FreeType dwFreeType);
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern UIntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion
        public DLLInformation inject(int pid, string dllPath)
        {
            DLLInformation d = new DLLInformation();
            d.ProcID = pid;
            IntPtr hProcess = OpenProcess((int)(0x000F0000L | 0x00100000L | 0xFFF), false, pid);
            d.ErrorCode = commonInject(hProcess, dllPath, ref d);
            return d;
        }
        public DLLInformation inject(string exePath, string dllPath)
        {
            DLLInformation d = new DLLInformation();
            STARTUPINFO lpStartupInfo = new STARTUPINFO();
            PROCESS_INFORMATION lpProcessInfo = new PROCESS_INFORMATION();
            SECURITY_ATTRIBUTES lpSecurityAttributes1 = new SECURITY_ATTRIBUTES();
            SECURITY_ATTRIBUTES lpSecurityAttributes2 = new SECURITY_ATTRIBUTES();
            lpSecurityAttributes1.nLength = Marshal.SizeOf(lpSecurityAttributes1);
            lpSecurityAttributes2.nLength = Marshal.SizeOf(lpSecurityAttributes2);
            IntPtr hProcess;
            CreateProcess(exePath, "", ref lpSecurityAttributes1, ref lpSecurityAttributes2, false, 0x0020, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInfo);
            hProcess = OpenProcess((int)(0x000F0000L | 0x00100000L | 0xFFF), false, lpProcessInfo.dwProcessId);
            d.ProcID = lpProcessInfo.dwProcessId;
            d.ErrorCode = commonInject(hProcess, dllPath, ref d);
            return d;
        }
        public int unject(DLLInformation d)
        {
            try
            {
                if (!d.IsInjected)
                {
                    return -2;
                }
                IntPtr hProcess = OpenProcess((int)(0x000F0000L | 0x00100000L | 0xFFF), false, d.ProcID);
                if (hProcess == null || hProcess.ToInt32() == -1)
                {
                    return 1;
                }
                uint x = 0;
                IntPtr loc = new IntPtr(GetProcAddress(GetModuleHandle("KERNEL32.dll"), "FreeLibrary").ToUInt32());
                IntPtr hThread = CreateRemoteThread(hProcess, new IntPtr(0), 0, loc, new IntPtr(d.DllHandle), 0, out x);
                if (hThread == null || hThread.ToInt32() == -1)
                {
                    return 2;
                }
                WaitForSingleObject(hThread, uint.MaxValue);
                uint exitCode;
                if (!GetExitCodeThread(hThread, out exitCode))
                {
                    return 3;
                }
                CloseHandle(hThread);
                CloseHandle(hProcess);
                d.IsInjected = false;
                return 0;
            }
            catch
            {
                return -1;
            }
        }
        private int commonInject(IntPtr hProcess, string dllPath, ref DLLInformation d)
        {
            if (d == null)
                d = new DLLInformation();
            d.DllPath = dllPath;
            if (hProcess == null || hProcess.ToInt32() == -1)
            {
                return 1;
            }
            IntPtr memory = VirtualAllocEx(hProcess, new IntPtr(0), (uint)dllPath.Length, AllocationType.Commit, MemoryProtection.ReadWrite);
            if (memory == null || memory.ToInt32() == 0)
            {
                return 2;
            }
            UIntPtr p;
            byte[] data = Encoding.ASCII.GetBytes(dllPath);
            if (!WriteProcessMemory(hProcess, memory, data, (uint)dllPath.Length, out p))
            {
                return 3;
            }
            uint x = 0;
            IntPtr loc = new IntPtr(GetProcAddress(GetModuleHandle("KERNEL32.DLL"), "LoadLibraryA").ToUInt32());
            IntPtr hThread = CreateRemoteThread(hProcess, new IntPtr(0), 0, loc, memory, 0, out x);
            if (hThread == null || hThread.ToInt32() == -1)
            {
                return 4;
            }
            WaitForSingleObject(hThread, uint.MaxValue);
            uint exitCode;
            if (!GetExitCodeThread(hThread, out exitCode))
            {
                return 5;
            }
            d.DllHandle = exitCode;
            CloseHandle(hThread);
            VirtualFreeEx(hProcess, memory, dllPath.Length + 1, FreeType.Release);
            d.IsInjected = true;
            return 0;
        }
    }
}