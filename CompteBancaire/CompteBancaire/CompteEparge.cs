using System;
using System.Collections.Generic;
namespace CompteBancaire
{
    public  class CompteEparge : Compte
    {
        private double Taux;


        public CompteEparge(double taux)
        {
            Taux = taux;
        }



        public override double Solde
        {
            get
            {
                double res = 0;
                res = base.Solde * (1 + Taux);
                return res;}
        }

        public override void AfficheResume()
        {
            Console.Write("\n******" + "CompteEpargne de " + Proprietaire + "******");
            Console.Write("\nSolde " + Solde );
            foreach (Operation op in listDesOps)
            {
                if (op.TypeMouvement == Operation.Mouvement.Debit)
                {
                    Console.Write("\nDebit Op: + " + op.Somme);
                }

                else
                {
                    Console.Write("\nCredit Op: - " + op.Somme);
                }
            }
            Console.Write("\nSolde " + Solde);
        }
    }

}
