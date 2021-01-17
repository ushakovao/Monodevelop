using System;

namespace refWord
// C# program to illustrate the 
// use of ref keyword 

{

    class GFG
    {

        // Main Method 
        static void Main(string[] args)
        {

            // Initialize a and b 
            int a = 10, b = 12;

            // Display initial values 
            Console.WriteLine("Initial value of a is {0}", a);
            Console.WriteLine("Initial value of b is {0}", b);
            Console.WriteLine();

            // Call addValue method by value 
            addValue(a);

            // Display modified value of a 
            Console.WriteLine("Value of a after addition" +
                                " operation is {0}", a);

            // Call subtractValue method by ref 
            subtractValue(ref b);

            // Display modified value of b 
            Console.WriteLine("Value of b after " +
                "subtration operation is {0}", b);

            Fakepermutation(a, b);
            Console.WriteLine("Value after fake permutation a=" + a + "b =" + b);

            permutation(ref a, ref b);
            Console.WriteLine("Value after permutation a=" + a + "b =" + b);
        }

        // Define addValue 
        // Parameters passed by value 
        public static void addValue(int a)
        {   
            a += 5;
            Console.WriteLine("Value of inner a=" + a);
        
        }


        // Define subtractValue 
        // Parameters passed by ref 
        public static void subtractValue(ref int b)
        {
            b -= 5;
        }


         
        public static void permutation(ref int  a, ref int  b)
        {
            int x = a;
            a = b;
            b = x;
            Console.WriteLine("Value of inner proper permuted a=" + a+ " b=" + b);

        }

        public static void Fakepermutation( int a,  int b)
        {
            int x = a;
            a = b;
            b = x;
            Console.WriteLine("Value of inner fake permuted a=" + a + " b=" + b);

        }

    }
}
