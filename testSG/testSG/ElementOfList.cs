using System;
namespace testSG
{
    public class ElementOfList<T>
    {

        public ElementOfList<T> Next { get; set; }
        public ElementOfList<T> Previous { get; set; }
        public T value;


        public ElementOfList()
        {
           
            
        }
    }
}
