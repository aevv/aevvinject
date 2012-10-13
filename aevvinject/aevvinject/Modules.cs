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
    public partial class Modules : Form
    {
        public Modules(ProcessModuleCollection m)
        {
            InitializeComponent();
            for (int x = 0; x < m.Count; x++)
            {
                lbModules.Items.Add(m[x].ModuleName);
            }
        }

        private void Modules_Load(object sender, EventArgs e)
        {

        }
    }
}
