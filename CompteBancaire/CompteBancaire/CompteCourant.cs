using System;
using System.Collections.Generic;
namespace CompteBancaire
{
    public  class CompteCourant : Compte
    {

        private int decouvertAutorise;

        public CompteCourant(int taux)
        {
            decouvertAutorise = taux;
        }

        public override void AfficheResume()
        {
            Console.Write("\n******" + "CompteCourant de " + Proprietaire + "******");
            Console.Write("\nSolde " + Solde);
            foreach (Operation op in listDesOps)
            {
                if (op.TypeMouvement == Operation.Mouvement.Debit)
                {
                    Console.Write("\nDebit Operation : + " + op.Somme);
                }

                else
                {
                    Console.Write("\nCredit Operation : - " + op.Somme);
                }
            }
            Console.Write("\nSolde " + Solde);
        }
    }
}