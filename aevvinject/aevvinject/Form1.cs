using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace aevvinject
{
    public partial class Form1 : Form
    {
        ProcessWrapper activeProcess = null;
        Injector i = new Injector();
        List<ProcessWrapper> lProcs = new List<ProcessWrapper>();
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
            activeProcess = (ProcessWrapper)lbProcesses.SelectedItem;
            updateSelected();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            refreshProcessList();
        }
        private void refreshProcessList()
        {
            lbProcesses.Items.Clear();
            Process[] procs = Process.GetProcesses();
            lProcs.Clear();
            foreach (Process p in procs)
            {
                ProcessWrapper w = new ProcessWrapper(p);
                lProcs.Add(w);
            }
            foreach (ProcessWrapper w in lProcs)
            {
                lbProcesses.Items.Add(w);
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
    }
}
