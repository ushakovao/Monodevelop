using System;
using System.Collections.Generic;

namespace CompteInterface
{
    public abstract class Compte
    {
        public string Nom;
        public List<Operation> listeDesOps;

        public Compte()
        {
            listeDesOps = new List<Operation>();
        }


        public void Crediter(double somme)
        {
            Operation o = new Operation { Montant = somme, TypeDeMovement = Operation.Movement.credit };
            listeDesOps.Add(o);
        }


        public void Crediter(double somme, Compte compte)
        {
            Crediter(somme);
            compte.Debiter(somme);
        }


        public void Debiter(double somme)
        {
            Operation o = new Operation { Montant = somme, TypeDeMovement = Operation.Movement.debit };
            listeDesOps.Add(o);
        }


        public void Debiter(double somme, Compte compte)
        {
            Debiter(somme);
            compte.Crediter(somme);
        }



        public virtual double Solde 
        { get 
            {

             double total = 0;
            foreach (Operation o in listeDesOps)
            {
                    if (o.TypeDeMovement == Operation.Movement.debit)
                    {
                        total -= o.Montant;
                    }
                     else
                    {
                        total += o.Montant;
                    }

                }
                return total;
            }
    
            }

        public abstract void Afficher();

    }


    public class CompteEpargne : Compte
    {
        private double taux;
        public CompteEpargne(double m_taux)
        {
            taux = m_taux;
        }
        public override double Solde
        {
            get
            {
                return (base.Solde * (1 + taux));
            }
        }

        public override void Afficher()
        {
            Console.WriteLine("*****Compte Epargne*****");
            Console.WriteLine("Name " + Nom);
            Console.WriteLine("SOlde " + Solde);
            Console.WriteLine("Taux "+ taux);
            foreach (Operation o in listeDesOps)
            {
                Console.WriteLine("Type {0} --- montant {1}", o.TypeDeMovement.ToString(),o.Montant );
            }
            Console.WriteLine("**********************");
        }

    }

    public class CompteCourant : Compte
    {
        private double decouvert;
        public CompteCourant(double m_decouvert)
        {
            decouvert = m_decouvert;
        }

        public override void Afficher()
        {
            Console.WriteLine("*****Compte Courant*****");
            Console.WriteLine("Name " + Nom);
            Console.WriteLine("SOlde " + Solde);
            Console.WriteLine("Decouvert " + decouvert);
            foreach (Operation o in listeDesOps)
            {
                Console.WriteLine("Type {0} --- montant {1}", o.TypeDeMovement.ToString(), o.Montant);
            }
            Console.WriteLine("**********************");
        }
    }

    public class Operation
    {
        public enum Movement
        {
            credit,
            debit
        }

        public Movement TypeDeMovement { get; set; }

        public double Montant { get; set; }

    }


}
