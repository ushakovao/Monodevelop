using System;
namespace LinkedListBest
{
    public class Chain<T>
    {
        public ChainNode<T> Premier { get; private set; }
        public ChainNode<T> Last
        {
            get

            {
                if (Premier == null)
                {
                    return null;
                }
                ChainNode<T> last = Premier;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                return last;
            }
        }




        public void AddNode(T toAdd)
        {
            if (Premier == null)
            {
                Premier = new ChainNode<T> { Value = toAdd };
            }

            else
            {
                ChainNode<T> last = Last;
                last.Next = new ChainNode<T> { Value = toAdd, Prev = last };
            }
        }




        public void DeleteNode(T toDelete)
        {

            ChainNode<T> temp = Premier;
            ChainNode<T> prev = null;

            if (Premier.Value.Equals(toDelete))
            {
                Premier = temp.Next;
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

        public ChainNode<T> FindAtIndex(int index)
        {

            ChainNode<T> res = Premier;
            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    return res;
                }
               

                if (res.Next == null)
                {
                    Console.WriteLine("No object found at this index");
                    return null;
                    
                }
                else
                {
                    res = res.Next;
                }
               
            }
            return res;
        }


        public int? GetIndexOf (T whatIsMyIndex)
        {
            ChainNode<T> temp = Premier;
            int counter = 0;

            while (!(temp.Value.Equals(whatIsMyIndex)))
            {

                counter++;
                if (temp.Next == null)
                {
                    break;
                }

                temp = temp.Next;
            }


            ChainNode<T> res = FindAtIndex(counter);

            if (res==null)
            {
                Console.WriteLine("this object is not in the list");
                return -1;

            }

            else
            {
                Console.WriteLine("this object is  in the list  ->  ");
                return counter;
            }





        }



    }
    } 

