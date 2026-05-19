using System;
using System.Collections.Generic;
using MediaTek86.bddmanager;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class FrmAjoutAbsence : Form
    {
        private int idPersonnel = 0;
        private DateTime ancienneDateDebut;
        public FrmAjoutAbsence()
        {
            InitializeComponent();
            cmbPersonnel.Items.Add("1 - Martin Julie");
            cmbPersonnel.Items.Add("2 - Bernard Lucas");
            cmbPersonnel.Items.Add("3 - Dubois Emma");

            cmbMotif.Items.Add("vacances");
            cmbMotif.Items.Add("maladie");
            cmbMotif.Items.Add("motif familial");
            cmbMotif.Items.Add("congé parental");

        }
        public FrmAjoutAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, string motif)
        {
            InitializeComponent();

            this.idPersonnel = idPersonnel;
            this.ancienneDateDebut = dateDebut;

            cmbPersonnel.Items.Add("1 - Martin Julie");
            cmbPersonnel.Items.Add("2 - Bernard Lucas");
            cmbPersonnel.Items.Add("3 - Dubois Emma");

            cmbMotif.Items.Add("vacances");
            cmbMotif.Items.Add("maladie");
            cmbMotif.Items.Add("motif familial");
            cmbMotif.Items.Add("congé parental");

            cmbPersonnel.SelectedIndex = idPersonnel - 1;
            dtDebut.Value = dateDebut;
            dtFin.Value = dateFin;
            cmbMotif.Text = motif;

            btnAjouter.Text = "Modifier";
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = AccessBDD.GetConnection();

            string requete = "";

            if (idPersonnel == 0)
            {
                requete =
                "insert into absence(idpersonnel, datedebut, datefin, idmotif) " +
                "values(@idpersonnel, @datedebut, @datefin, @idmotif)";
            }
            else
            {
                requete =
                "update absence set datedebut=@datedebut, datefin=@datefin, idmotif=@idmotif " +
                "where idpersonnel=@ancienidpersonnel and datedebut=@anciennedatedebut";
            }

            MySqlCommand cmd = new MySqlCommand(requete, connexion);

            cmd.Parameters.AddWithValue("@datedebut", dtDebut.Value);
            cmd.Parameters.AddWithValue("@datefin", dtFin.Value);
            cmd.Parameters.AddWithValue("@idmotif", cmbMotif.SelectedIndex + 1);

            if (idPersonnel == 0)
            {
                cmd.Parameters.AddWithValue("@idpersonnel", cmbPersonnel.SelectedIndex + 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ancienidpersonnel", idPersonnel);
                cmd.Parameters.AddWithValue("@anciennedatedebut", ancienneDateDebut);
            }

            cmd.ExecuteNonQuery();

            connexion.Close();

            MessageBox.Show("Absence enregistrée !");
            this.Close();
        }
    }
}
