using System;
namespace LinkedListFinal
{
    public class List<T>
    {

        public ListNode<T> First { get; private set; }
        public ListNode<T> Last { get

            {
                if (First == null)
                {
                    return null;
                }

                ListNode<T> last = First;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                return last;

            }
        }


        public void AddElement (T toAdd)
        {
            if (First == null)
            {
                First = new ListNode<T> { Value = toAdd };
            }

            else
            {
                ListNode<T> last = Last;
                last.Next = new ListNode<T> { Value = toAdd, Prev = last };
            }
        }

        public int? FindByIndex(T toFind)
        {
            ListNode<T> temp = First;
            int counter = 0;

            while (!(temp.Value.Equals(toFind)))
            {

                if (temp.Next == null)
                {
                    temp.Value=toFind;
                    break;
                }

                else
                {
                    temp = temp.Next;
                    counter++;
                }                

            }

            if (temp.Value.Equals(FindAtIndex(counter)))
            {
                Console.WriteLine("Find by index " + counter);
                return counter;
            }

            else {

                Console.WriteLine("Value {0} is not found", temp.Value);
                return null;
            }



           }


        public T FindAtIndex(int index)
        {
            ListNode<T> temp = First;
            for (int i=0; i<= index; i++)
            {
                if (temp.Next == null)
                {
                    Console.WriteLine("Nothing found at given index = " + index);
                    return default(T);

                }


                else 
                {
                    temp = temp.Next;
                   
                }

            }
            Console.WriteLine("Find at index " + temp.Value);
            return temp.Value;

        }


        public void DeleteElement (T toDelete)
        {
            ListNode<T> temp = First;
            ListNode<T> prev = null;

            if (First.Value.Equals(toDelete))
            {
                First = temp.Next;
                return;
            }


            while (!(temp.Value.Equals(toDelete)))
            {

                prev = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                return;
            }

            prev.Next = temp.Next;

        }


        public void AddElementAtAnyPoint(T toAdd, T toMovetoNext)
        {
            ListNode<T> temp = First;
            ListNode<T> prev = null;
            ListNode<T> toAddNode = new ListNode<T> { Value = toAdd };

            if (First.Value.Equals(toMovetoNext))
            {
                temp = First.Next;// = B
                First = toAddNode;// = X
                First.Next = temp.Prev;// = A


            }




            else
            {

                    while (!(temp.Value.Equals(toMovetoNext)))
                    {
                    prev = temp;
                    temp = temp.Next; // temp is MoveToNext
                    }


                    toAddNode.Prev = prev;
                    toAddNode.Next = temp;
                    temp.Prev = toAddNode;
                    prev.Next = toAddNode;
            }

            }




        public List()
        {
        }
    }
}
