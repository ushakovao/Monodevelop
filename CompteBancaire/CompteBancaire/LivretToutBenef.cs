using System;
namespace CompteBancaire
{
    public class LivretToutBenef : Compte
    {
        private ICalc Icalc;
        public LivretToutBenef(ICalc icalc)
        {
            Icalc = icalc;
        }

        public override double Solde
        {
            get
            {
                double solde = base.Solde;
                return solde + Icalc.Icalc(solde);

            }
        }

                

        public override void AfficheResume()
        {

            Console.Write("\n******" + "Livret de " + Proprietaire + "******");
            Console.Write("\nTaux " + Icalc.Taux);
            Console.Write("\nSolde " + Solde);
        }


    }
}

