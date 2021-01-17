using System;

namespace TP_Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ListeEnchainee<string> myLE = new ListeEnchainee<string>();
            myLE.Ajouter("If");
            myLE.Ajouter("you");
            myLE.Ajouter("happy");
            myLE.Ajouter("and");
            myLE.Ajouter("you");
            Console.WriteLine(myLE.Premier.Valeur);
            Console.WriteLine(myLE.Premier.Suivant.Valeur);
            Console.WriteLine(myLE.Premier.Suivant.Suivant.Valeur);
            Console.WriteLine(myLE.Premier.Suivant.Suivant.Suivant.Valeur);
            Console.WriteLine(myLE.Premier.Suivant.Suivant.Suivant.Suivant.Valeur);
            Console.WriteLine("*********************");
            Console.WriteLine(myLE.ObtenirElement(0).Valeur);
            Console.WriteLine(myLE.ObtenirElement(1).Valeur);
            Console.WriteLine(myLE.ObtenirElement(2).Valeur);
            Console.WriteLine(myLE.ObtenirElement(3).Valeur);
            Console.WriteLine(myLE.ObtenirElement(4).Valeur);

            Console.WriteLine("*********************");

            myLE.Inserer("BLANK1", 1);
            myLE.Inserer("BLANK2", 3);

            Console.WriteLine(myLE.ObtenirElement(0).Valeur);
            Console.WriteLine(myLE.ObtenirElement(1).Valeur);
            Console.WriteLine(myLE.ObtenirElement(2).Valeur);
            Console.WriteLine(myLE.ObtenirElement(3).Valeur);
            Console.WriteLine(myLE.ObtenirElement(4).Valeur);
            Console.WriteLine(myLE.ObtenirElement(5).Valeur);
            Console.WriteLine(myLE.ObtenirElement(6).Valeur);

        }
    }
}
