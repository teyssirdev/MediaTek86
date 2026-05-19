using MediaTek86.bddmanager;
using MediaTek86.dal;
using MySql.Data.MySqlClient;
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
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
            DataTable dt = AccessPersonnel.GetLesPersonnels();
            dgvPersonnel.DataSource = dt;
            dgvPersonnel.Columns["idpersonnel"].HeaderText = "ID";
            dgvPersonnel.Columns["nom"].HeaderText = "Nom";
            dgvPersonnel.Columns["prenom"].HeaderText = "Prénom";
            dgvPersonnel.Columns["service"].HeaderText = "Service";

            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPersonnel.ReadOnly = true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjoutPersonnel frm = new FrmAjoutPersonnel();
            frm.ShowDialog();

            DataTable dt = AccessPersonnel.GetLesPersonnels();
            dgvPersonnel.DataSource = dt;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPersonnel.CurrentRow.Cells[0].Value);

            MySqlConnection connexion = AccessBDD.GetConnection();

            string requete = "delete from personnel where idpersonnel = @id";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            connexion.Close();

            MessageBox.Show("Personnel supprimé");

            DataTable dt = AccessPersonnel.GetLesPersonnels();
            dgvPersonnel.DataSource = dt;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPersonnel.CurrentRow.Cells[0].Value);

            string nom = dgvPersonnel.CurrentRow.Cells[1].Value.ToString();
            string prenom = dgvPersonnel.CurrentRow.Cells[2].Value.ToString();
            string service = dgvPersonnel.CurrentRow.Cells[3].Value.ToString();

            FrmAjoutPersonnel frm = new FrmAjoutPersonnel(id, nom, prenom, "", "", service);

            frm.ShowDialog();

            DataTable dt = AccessPersonnel.GetLesPersonnels();
            dgvPersonnel.DataSource = dt;
        }
    }
}
