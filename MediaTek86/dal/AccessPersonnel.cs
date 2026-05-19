using MediaTek86.bddmanager;
using MySql.Data.MySqlClient;
using System.Data;

namespace MediaTek86.dal
{
    class AccessPersonnel
    {
        public static DataTable GetLesPersonnels()
        {
            DataTable dt = new DataTable();

            MySqlConnection connexion = AccessBDD.GetConnection();

            string requete =
                "select personnel.idpersonnel, personnel.nom, personnel.prenom, service.nom as service " +
                "from personnel " +
                "join service on personnel.idservice = service.idservice;";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(dt);

            connexion.Close();

            return dt;
        }
    }
}
