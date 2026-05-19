using MediaTek86.dal;
using MediaTek86.modele;

namespace MediaTek86.controleur
{
    class Controle
    {
        public static Utilisateur ControleAuthentification(string login, string pwd)
        {
            return AccessUtilisateur.ControleAuthentification(login, pwd);
        }
    }
}
