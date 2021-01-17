using System;
namespace testSG
{
    public class LinkedList<T>
    {

        //First and last elements
        public ElementOfList<T> Premier {get; set;}
        public ElementOfList<T> Last { get; set; } //to fix


        //add an element
        public void AddElement (T newElement)
        {
            if (Premier == null)
            {
                Premier = new ElementOfList<T> { value = newElement};
                Last = Premier;
            }

            else
            {
                ElementOfList<T> last = Last;
                last.Next = new ElementOfList<T> { value = newElement, Previous = last };
            
            }
           }

        //delete last element

            public void DeleteValue (T toDelete)
        {

            ElementOfList<T> temp = Premier;
            //int i = 0;
            while(!(temp.value.Equals(toDelete)))
            {
             
                if (temp.Next == null)
                {
                    Console.WriteLine("End loop");
                    break;
                }
                temp = temp.Next;

            }
            if (temp.value.Equals(toDelete))
            {



                temp.Previous.Next = temp.Next;
                temp.Next.Previous = temp.Previous;
                temp.Next = null;
                temp.Previous = null;
                temp.value = default(T);

            }




        }

        //recherche par indice

        public void SearchBIndex(int index)
        {
            ElementOfList<T> t = Premier; 
            for (int i=1; i<= index; i++)
            {
                t = t.Next;

            }

        }











        public LinkedList()
        {
        }
    }
}
