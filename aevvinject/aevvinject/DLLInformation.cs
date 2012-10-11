using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aevvinject
{
    class DLLInformation
    {
        public override string ToString()
        {
            string[] s = dllPath.Split('\\');
            return s[s.Length-1];
        }
        bool isInjected;

        public bool IsInjected
        {
            get { return isInjected; }
            set { isInjected = value; }
        }
        uint dllHandle;

        public uint DllHandle
        {
            get { return dllHandle; }
            set { dllHandle = value; }
        }
        int procID;

        public int ProcID
        {
            get { return procID; }
            set { procID = value; }
        }
        string dllPath;

        public string DllPath
        {
            get { return dllPath; }
            set { dllPath = value; }
        }
        int errorCode;

        public int ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }
    }
}
