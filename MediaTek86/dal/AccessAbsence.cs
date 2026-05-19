using MediaTek86.bddmanager;
using MySql.Data.MySqlClient;
using System.Data;

namespace MediaTek86.dal
{
    class AccessAbsence
    {
        public static DataTable GetLesAbsences()
        {
            DataTable dt = new DataTable();

            MySqlConnection connexion = AccessBDD.GetConnection();

            string requete =
                "select absence.idpersonnel, personnel.nom, personnel.prenom, absence.datedebut, absence.datefin, motif.libelle as motif " +
                "from absence " +
                "join personnel on absence.idpersonnel = personnel.idpersonnel " +
                "join motif on absence.idmotif = motif.idmotif;";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(dt);
            connexion.Close();

            return dt;
        }
    }
}
