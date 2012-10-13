using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aevvinject
{
    public partial class ProcessInformation : Form
    {
        private ProcessWrapper active;
        public ProcessInformation(ProcessWrapper p)
        {
            active = p;
            InitializeComponent();
            lvInfo.Items.Add(new ListViewItem(new string[] { "Name", p.Process.ProcessName }));
            lvInfo.Items.Add(new ListViewItem(new string[] { "PID", p.Process.Id.ToString() }));
            lvInfo.Items.Add(new ListViewItem(new string[] { "Handle", p.Process.Handle.ToString() }));
            lvInfo.Items.Add(new ListViewItem(new string[] { "Title", p.Process.MainWindowTitle }));
            lvInfo.Items.Add(new ListViewItem(new string[] { "Threads", p.Process.Threads.Count.ToString() }));
            lvInfo.Items.Add(new ListViewItem(new string[] { "Memory", (p.Process.WorkingSet64 / 1000).ToString() + "KB" }));
        }

        private void ProcessInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void bModules_Click(object sender, EventArgs e)
        {
            try
            {
                new Modules(active.Process.Modules).ShowDialog();
            }
            catch
            {

            }
        }

        private void bKill_Click(object sender, EventArgs e)
        {
            active.Process.Kill();
        }
    }
}
