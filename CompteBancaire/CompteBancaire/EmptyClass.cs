using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Program.cs : Fichier principal de l'application
 * par RayonGama
 * 8/01/2012
*/
namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Compte> listeCompte = new List<Compte>();

            Compte compteCourantNico = new CompteCourant(0, "Nico", 2000);
            Compte compteEntrepriseNico = new CompteEpargne(0, "Nico", 0.2);
            Compte compteCourantJeremie = new CompteCourant(0, "Jeremie", 500);

            compteCourantNico.Crediter(100);
            compteCourantNico.Debiter(50);
            compteEntrepriseNico.Crediter(20, compteCourantNico);
            compteCourantNico.Crediter(100);

            compteCourantJeremie.Debiter(500);
            compteCourantJeremie.Debiter(200, compteCourantNico);

            listeCompte.Add(compteCourantNico);
            listeCompte.Add(compteEntrepriseNico);
            listeCompte.Add(compteCourantJeremie);

            foreach (Compte pCompte in listeCompte)
            {
                if (pCompte.Solde > 0)
                    Console.WriteLine("Bienvenue à la banque VP");
                else
                    Console.WriteLine("Compte réfusé à la banque VP");

                pCompte.ResumeCompte();
            }

            Console.ReadLine();


        }
    }
}