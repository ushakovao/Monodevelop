using System;
namespace Generics
{
    public class LinkedList <T>
    {
        private T firstElement;
        private T lastElement;
        private T nextElement;
        private T previousElement;
        private int capacity;
        private int nbOfElements;
        private T[] table;


        public LinkedList()
        {
            capacity = 10;
            nbOfElements = 0;
            table = new T[capacity];
        }

  

        public void AddElementAtTheEnd (T newElement)
        {
            table[nbOfElements] = newElement;
            nbOfElements++; 
        }

        public T AccesByIndice(int index)
        {
            return table[index];
        }

        public void InsertAtIndex(T newElement, int index)
        {

            for (int i = nbOfElements+1; i > index; i--)
            {
                table[i] = table[i - 1];

            }

            table[index] = newElement;
            nbOfElements++;

        }


        public T NextElement(T element)
        {
            bool found = false;

            T toReturn = default(T);
            int iToReturn = 0;
            int i = 0;
            while (!found)
            {
                if (table[i].Equals(element)) {
                    toReturn = table[i];
                    iToReturn = i;
                    found = true;
                    
                }
                i++;
            }

            if (iToReturn == nbOfElements)
            {
                Console.WriteLine("No next element, its the last");
                return table[iToReturn];
            }
            else
            {
                Console.WriteLine("Next element is " + table[iToReturn + 1]);
                return table[iToReturn + 1];
            }

           
        }


        public T PreviousElement(T element)
        {
            bool found = false;

            T toReturn = default(T);
            int iToReturn = 0;
            int i = 0;
            while (!found)
            {
                if (table[i].Equals(element))
                {
                    toReturn = table[i];
                    iToReturn = i;
                    found = true;

                }
                i++;
            }

            if(iToReturn == 0)
            {
                Console.WriteLine("No previoud element, its the first");
                return table[iToReturn];
            }
            else
            {
                Console.WriteLine("Previous element is " + table[iToReturn - 1]);
                return table[iToReturn - 1];
            }


        }


















    }
}
