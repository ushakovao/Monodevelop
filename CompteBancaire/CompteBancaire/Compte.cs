using System;
using System.Collections.Generic;
namespace CompteBancaire
{
    public abstract class Compte
    {
        protected List<Operation> listDesOps = new List<Operation>();
        public string Proprietaire { get;  set; }
        //we can't set Solde, only get
        public virtual double  Solde {
            get
            {
                double total = 0;
                foreach (Operation op in listDesOps)
                {
                    if (op.TypeMouvement == Operation.Mouvement.Debit){
                        total = total - op.Somme;
                    }
                    else
                    {
                        total = total + op.Somme;
                    }
                }
                return total;
            }


        }

        public void Crediter(double somme)
        {
            Operation op = new Operation
            {
                Somme = somme,
                TypeMouvement = Operation.Mouvement.Credit
            };

            listDesOps.Add(op);
        }


        public void Debiter(double somme)
        {
            Operation op = new Operation
            {
                Somme = somme,
                TypeMouvement = Operation.Mouvement.Debit
            };

            listDesOps.Add(op);
        }


        public void Crediter(double somme, Compte compte)
        {
            Crediter(somme);
            compte.Debiter(somme);

        }

        public void Debiter(double somme, Compte compte)
        {
            Debiter(somme);
            compte.Crediter(somme);

        }

        public abstract void AfficheResume();



    }
}