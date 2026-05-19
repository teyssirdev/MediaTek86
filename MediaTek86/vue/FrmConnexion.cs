using MediaTek86.bddmanager;
using MediaTek86.controleur;
using MediaTek86.modele;
using MediaTek86.vue;
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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();

            try
            {
                AccessBDD.GetConnection();
                MessageBox.Show("Connexion réussie !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = Controle.ControleAuthentification(txtLogin.Text, txtPwd.Text);

            if (utilisateur != null)
            {
                FrmAccueil frm = new FrmAccueil();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect");
            }
        }
    }
}
