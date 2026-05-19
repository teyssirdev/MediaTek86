namespace MediaTek86.modele
{
    class Utilisateur
    {
        public string Login { get; set; }
        public string MotDePasse { get; set; }

        public Utilisateur(string login, string motDePasse)
        {
            this.Login = login;
            this.MotDePasse = motDePasse;
        }
    }
}
