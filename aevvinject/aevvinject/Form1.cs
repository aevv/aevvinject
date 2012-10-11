using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;

namespace aevvinject
{
    public partial class Form1 : Form
    {
        ProcessWrapper activeProcess = null;
        Injector i = new Injector();
        Dictionary<string, ProcessWrapper> lProcs = new Dictionary<string, ProcessWrapper>();
        public Form1()
        {
            InitializeComponent();
            refreshProcessList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bSelectProc_Click(object sender, EventArgs e)
        {

          
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            refreshProcessList();
        }
        private string GetMainModuleFilepath(int processId)
        {
            string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + processId;
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            {
                using (var results = searcher.Get())
                {
                    ManagementObject mo = results.Cast<ManagementObject>().FirstOrDefault();
                    if (mo != null)
                    {
                        return (string)mo["ExecutablePath"];
                    }
                }
            }
            return null;
        }
        ImageList il = new ImageList(); //caches icons
        private void refreshProcessList()
        {
            lbProcesses.Items.Clear();
            Process[] procs = Process.GetProcesses();
            lProcs.Clear();            
            
            foreach (Process p in procs)
            {
                ProcessWrapper w = new ProcessWrapper(p);
                Icon ico = null;
                if (!il.Images.ContainsKey(p.Id.ToString()))
                {
                    try
                    {

                        ico = Icon.ExtractAssociatedIcon(p.MainModule.FileName);
                        Bitmap bm = new Bitmap(ico.Width, ico.Height);
                        using (Graphics g = Graphics.FromImage(bm))
                        {
                            g.DrawIcon(ico, 0, 0);
                        }
                        il.Images.Add(p.MainModule.FileName, bm);


                    }
                    catch
                    {
                        //  il.Images.Add(p.Id.ToString(),Image.FromHbitmap(aevvinject.Properties.Resources.refresh.GetHbitmap()));
                    };
                }
                
                
                
                lProcs.Add(p.Id.ToString(),w);
            }
            lbProcesses.SmallImageList = il;
            
            foreach (var q in lProcs)
            {
                ProcessWrapper w = q.Value;
                try
                {
                    lbProcesses.Items.Add(new ListViewItem(new string[] { w.Process.ProcessName, w.Process.Id.ToString() }, w.Process.MainModule.FileName));
                }
                catch
                {
                    lbProcesses.Items.Add(new ListViewItem(new string[] { w.Process.ProcessName, w.Process.Id.ToString() }));
                }
                
            }
        }
        private void updateSelected()
        {
            selectedBox.Text = "Currently selected: " + activeProcess.Process.ProcessName;
            lbInjected.Items.Clear();
            foreach (DLLInformation d in activeProcess.InjectedList)
            {
                if (d.IsInjected)
                    lbInjected.Items.Add(d);
            }
        }

        private void bBrowseDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                tbDllResult.Text = o.FileName;
            }
        }

        private void bInject_Click(object sender, EventArgs e)
        {
            activeProcess.InjectedList.Add(i.inject(activeProcess.Process.Id, tbDllResult.Text));
            updateSelected();
        }

        private void bUnject_Click(object sender, EventArgs e)
        {
            i.unject((DLLInformation)lbInjected.SelectedItem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProcesses.SelectedItems.Count > 0)
            {
                activeProcess = lProcs[lbProcesses.SelectedItems[0].SubItems[1].Text];
                updateSelected();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshProcessList();
        }

        private void selectedBox_Enter(object sender, EventArgs e)
        {

        }

        private void bSelectExe_Click(object sender, EventArgs e)
        {

        }

        private void bSelectPID_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
