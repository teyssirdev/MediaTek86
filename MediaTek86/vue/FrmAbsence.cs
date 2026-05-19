using System;
using System.Collections.Generic;
using System.ComponentModel;
using MediaTek86.bddmanager;
using MySql.Data.MySqlClient;
using MediaTek86.dal;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class FrmAbsence : Form
    {
        public FrmAbsence()
        {
            InitializeComponent();
            DataTable dt = AccessAbsence.GetLesAbsences();
            dgvAbsence.DataSource = dt;

            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAbsence.ReadOnly = true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjoutAbsence frm = new FrmAjoutAbsence();
            frm.ShowDialog();

            DataTable dt = AccessAbsence.GetLesAbsences();
            dgvAbsence.DataSource = dt;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idPersonnel = Convert.ToInt32(dgvAbsence.CurrentRow.Cells[0].Value);
            DateTime dateDebut = Convert.ToDateTime(dgvAbsence.CurrentRow.Cells[3].Value);

            MySqlConnection connexion = AccessBDD.GetConnection();

            string requete = "delete from absence where idpersonnel=@idpersonnel and datedebut=@datedebut";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);

            cmd.Parameters.AddWithValue("@idpersonnel", idPersonnel);
            cmd.Parameters.AddWithValue("@datedebut", dateDebut);

            cmd.ExecuteNonQuery();

            connexion.Close();

            MessageBox.Show("Absence supprimée");

            DataTable dt = AccessAbsence.GetLesAbsences();
            dgvAbsence.DataSource = dt;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int idPersonnel = Convert.ToInt32(dgvAbsence.CurrentRow.Cells[0].Value);
            DateTime dateDebut = Convert.ToDateTime(dgvAbsence.CurrentRow.Cells[3].Value);
            DateTime dateFin = Convert.ToDateTime(dgvAbsence.CurrentRow.Cells[4].Value);
            string motif = dgvAbsence.CurrentRow.Cells[5].Value.ToString();

            FrmAjoutAbsence frm = new FrmAjoutAbsence(idPersonnel, dateDebut, dateFin, motif);
            frm.ShowDialog();

            DataTable dt = AccessAbsence.GetLesAbsences();
            dgvAbsence.DataSource = dt;
        }
    }
}
