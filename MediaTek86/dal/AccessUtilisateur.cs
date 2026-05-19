using MediaTek86.bddmanager;
using MediaTek86.modele;
using MySql.Data.MySqlClient;

namespace MediaTek86.dal
{
    class AccessUtilisateur
    {
        public static Utilisateur ControleAuthentification(string login, string pwd)
        {
            Utilisateur utilisateur = null;

            MySqlConnection connexion = AccessBDD.GetConnection();

            string requete = "select login, pwd from responsable where login=@login and pwd=sha2(@pwd,256);";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                utilisateur = new Utilisateur(reader["login"].ToString(), reader["pwd"].ToString());
            }

            connexion.Close();

            return utilisateur;
        }
    }
}
