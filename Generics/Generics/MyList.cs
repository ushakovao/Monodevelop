using System;
namespace Generics
{
    public class MyList<T>
    {
        private int capacité;
        private int nbElements;
        private T[] table;


        public MyList()
        {
            capacité = 10;
            nbElements = 0;
            table = new T[capacité];
        }

        public void Ajouer(T element)
        {
            if (nbElements >= capacité)
            {
                Console.WriteLine("Too many elements");
            }
            else
            {
                table[nbElements] = element;
                Console.WriteLine("Just added "+ element);
                Console.WriteLine(table);
                nbElements= nbElements+1;
            }
        }

        public T GetValeur (int i)
        {

            return table[i];
        }

    }

}