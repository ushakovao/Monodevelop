using System;

namespace LinkedListBest
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Chain<string> myChain = new Chain<string>();
           // ChainNode<int> A = new ChainNode<int>() {Value = 1};
           // ChainNode<int> B= new ChainNode<int>() { Value = 2 };
           // ChainNode<int> C= new ChainNode<int>() { Value = 3 };
            myChain.AddNode("A");
            myChain.AddNode("B");
            myChain.AddNode("C");
            myChain.AddNode("D");
            myChain.AddNode("E");

            Console.WriteLine(myChain.Premier.Value);
            Console.WriteLine(myChain.Premier.Next.Value);
            Console.WriteLine(myChain.Premier.Next.Next.Value);
            Console.WriteLine(myChain.Premier.Next.Next.Next.Value);
            Console.WriteLine(myChain.Premier.Next.Next.Next.Next.Value);


            Console.WriteLine("Deleting A");
            myChain.DeleteNode("A");


            Console.WriteLine(myChain.Premier.Value);
            Console.WriteLine(myChain.Premier.Next.Value);
            Console.WriteLine(myChain.Premier.Next.Next.Value);
            Console.WriteLine(myChain.Premier.Next.Next.Next.Value);
            // Console.WriteLine(myChain.Premier.Next.Next.Next.Next.Value);


            Console.WriteLine("Getting element at 0 = A?");
            Console.WriteLine(myChain.FindAtIndex(0).Value);
            Console.WriteLine("Getting element at  3 = E?");
            Console.WriteLine(myChain.FindAtIndex(3).Value);
            Console.WriteLine("Getting element at  10?");
            Console.WriteLine(myChain.FindAtIndex(10)?.Value);





            Console.WriteLine("Getting index of E = 3?");
            Console.WriteLine(myChain.GetIndexOf("E"));
            Console.WriteLine("Getting index of W?");
            Console.WriteLine(myChain.GetIndexOf("W"));



            Console.ReadLine();
        }
    }
}
