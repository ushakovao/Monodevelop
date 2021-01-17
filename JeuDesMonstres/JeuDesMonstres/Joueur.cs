using System;
namespace JeuDesMonstres
{
    public class Joueur
    {
        private int Vie;
        private bool Vivant;
        protected De de;


        public Joueur(int vie)
        {
            Vie = vie;
        }

        public void Attaque (MonstreFacile monstre)
        {
            De lance = new De();
            int res = lance.LanceDesDes();

            monstre.Attaque

        }

        public void SubitDegats(int degat)
        {
            Vie = Vie - degat;
        }

        public int LanceLeDe()
        {
            return de.LanceLeDe();
        }
    }
}
