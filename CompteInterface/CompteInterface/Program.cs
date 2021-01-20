using System;

namespace CompteInterface
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CompteCourant compteOxana = new CompteCourant(100) {Nom = "Oxana"};
            CompteCourant compteNatalie = new CompteCourant(50) { Nom = "Natalie" };

            CompteEpargne ceOxana = new CompteEpargne(0.05) { Nom = "Oxana" };

            compteOxana.Crediter(1000);
            compteNatalie.Crediter(6000);

            compteOxana.Debiter(50, compteNatalie);
            compteOxana.Crediter(100);

            compteNatalie.Debiter(1000, ceOxana);

            compteOxana.Afficher();
            ceOxana.Afficher();
            compteNatalie.Afficher();





        }
    }
}
