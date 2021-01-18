using System;

namespace LinkedListFinal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            myList.AddElement("A");
            myList.AddElement("B");
            myList.AddElement("C");
            myList.AddElement("D");
            myList.AddElement("E");

            Console.WriteLine(myList.First.Value);
            Console.WriteLine(myList.First.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Value);

            Console.WriteLine("***************");
            myList.AddElementAtAnyPoint("X","A");
            Console.WriteLine(myList.First.Value);
            Console.WriteLine(myList.First.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Value);

            Console.WriteLine("***************");
            myList.AddElementAtAnyPoint("XX", "C");
            Console.WriteLine(myList.First.Value);
            Console.WriteLine(myList.First.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Next.Value);
            Console.WriteLine("***************");

            myList.AddElementAtAnyPoint("XXX", "E");
            Console.WriteLine(myList.First.Value);
            Console.WriteLine(myList.First.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Next.Next.Value);

            myList.AddElement("XXXX");
            Console.WriteLine(myList.First.Value);
            Console.WriteLine(myList.First.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Next.Next.Next.Next.Value);

            myList.DeleteElement("X");
            myList.DeleteElement("XX");
            myList.DeleteElement("XXX");
            myList.DeleteElement("XXXX");
            Console.WriteLine(myList.First.Value);
            Console.WriteLine(myList.First.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Value);
            Console.WriteLine(myList.First.Next.Next.Next.Next.Value);

        }
    }
}
