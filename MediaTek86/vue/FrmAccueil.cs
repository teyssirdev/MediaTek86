using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            FrmPersonnel frm = new FrmPersonnel();
            frm.ShowDialog();
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            FrmAbsence frm = new FrmAbsence();
            frm.ShowDialog();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
