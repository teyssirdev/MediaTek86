using System;
using MediaTek86.bddmanager;
using MySql.Data.MySqlClient;
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
    public partial class FrmAjoutPersonnel : Form
    {
        private int idPersonnel = 0; 
        public FrmAjoutPersonnel()
        {
            InitializeComponent();
            cmbService.Items.Add("administration");
            cmbService.Items.Add("médiation culturelle");
            cmbService.Items.Add("prêt");
        }
        public FrmAjoutPersonnel(int id, string nom, string prenom, string tel, string mail, string service)
        {
            InitializeComponent();

            idPersonnel = id;

            cmbService.Items.Add("administratif");
            cmbService.Items.Add("médiation culturelle");
            cmbService.Items.Add("prêt");

            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtTel.Text = tel;
            txtMail.Text = mail;
            cmbService.Text = service;

            btnAjouter.Text = "Modifier";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = AccessBDD.GetConnection();

            string requete;

            if (idPersonnel == 0)
            {
                requete = "insert into personnel(nom, prenom, tel, mail, idservice) values(@nom, @prenom, @tel, @mail, @idservice)";
            }
            else
            {
                requete = "update personnel set nom=@nom, prenom=@prenom, tel=@tel, mail=@mail, idservice=@idservice where idpersonnel=@id";
            }

            MySqlCommand cmd = new MySqlCommand(requete, connexion);

            cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);
            cmd.Parameters.AddWithValue("@idservice", cmbService.SelectedIndex + 1);

            if (idPersonnel != 0)
            {
                cmd.Parameters.AddWithValue("@id", idPersonnel);
            }

            cmd.ExecuteNonQuery();

            connexion.Close();

            MessageBox.Show("Opération réussie");

            this.Close();
        }

        private void FrmAjoutPersonnel_Load(object sender, EventArgs e)
        {

        }

        
    }
}
