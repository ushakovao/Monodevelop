using System;
namespace CompteBancaire
{
    public class BeneficeRandom : ICalc
    {
        private Random rnd;
        private double taux;

        public BeneficeRandom()
        {
            rnd = new Random();
            taux = rnd.NextDouble();
        }


        public double Icalc(double solde)
        {
            return solde * (1 + taux);
        }


        public double Taux
        {
            get
            {
                return taux;
            }
        }

    }
}
