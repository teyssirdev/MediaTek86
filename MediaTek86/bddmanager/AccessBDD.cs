using MySql.Data.MySqlClient;

namespace MediaTek86.bddmanager
{
    class AccessBDD
    {
        private static string connexionString =
            "server=localhost;database=mediatek86;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connexion = new MySqlConnection(connexionString);
            connexion.Open();
            return connexion;
        }
    }
}
