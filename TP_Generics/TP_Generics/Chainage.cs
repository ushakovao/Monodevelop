using System;
namespace TP_Generics
{
    public class Chainage<T>
    {
        public Chainage<T> Precedent { get; set; }
        public Chainage<T> Suivant { get; set; }
        public T Valeur;

    }
}
