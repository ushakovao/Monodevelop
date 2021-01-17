using System;
namespace JeuDesMonstres
{
    public class De
    {
        public De()
        {
        }

        public int LanceLeDe()
        {
           
            Random n = new Random();
            int tirage = n.Next(1, 7);

            return tirage;
        }
    }
}
