using System;
namespace CompteBancaire
{
    public class Operation
    {

        public enum Mouvement
        {
            Credit,
            Debit
        }

        public Mouvement TypeMouvement { get; set; }
        public double Somme {get; set;}
     
    }
}
