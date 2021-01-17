using System.Collections.Generic;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {


            CompteCourant compteDeNico = new CompteCourant (1000) { Proprietaire = "Nicolas"};
            compteDeNico.AfficheResume();

            CompteCourant compteDeOxana = new CompteCourant(200) { Proprietaire = "Oxana" };
            compteDeOxana.AfficheResume();

            CompteEparge compteDeOxanaEp = new CompteEparge(4000) { Proprietaire = "Oxana" };

            compteDeNico.Crediter(55, compteDeOxana);
            compteDeNico.AfficheResume();
            compteDeOxana.Crediter(1000);
            compteDeOxana.AfficheResume();

            compteDeOxanaEp.Debiter(6000);
            compteDeOxanaEp.AfficheResume();

            ICalc i = new BeneficeRandom();
            LivretToutBenef l = new LivretToutBenef(i);
            l.AfficheResume();
            l.Crediter(1000);
            l.AfficheResume();


        }
    }
}