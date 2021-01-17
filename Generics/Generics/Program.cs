using System;
using System.Collections.Generic;

namespace Generics
{
    class MainClass
    {

       

        public static void Afficheur<T> (T o)
        {
            Console.WriteLine("Affichage de l'objet: ");
            Console.WriteLine("Le type d'objet: " + o.GetType());
            Console.WriteLine("Affichage de l'objet: " + o.ToString());
        }


        public static void PermutingNoRef<T> (T t1, T t2)
        {
            Console.WriteLine("Before permutingNoRef t1=" + t1+ "  t2=" +t2);
            T temp = t1;
            t1 = t2;
            t2 = temp;
            Console.WriteLine("After permutingNoRef t1=" + t1 + "  t2=" + t2);
        }

        public static void Permuting<T> (ref T t1, ref T t2)
        {
            Console.WriteLine("Before permuting t1=" + t1 + "  t2=" + t2);
            T temp = t1;
            t1 = t2;
            t2 = temp;
            Console.WriteLine("After permuting t1=" + t1 + "  t2=" + t2);
        }

        public  static void BlaBla<T, U> (T t, U u)
        {
            Console.WriteLine(t + "   is   " + u);
        }


        public static void Main(string[] args)
        {


            LinkedList<int> myLL = new LinkedList<int>();
            myLL.AddElementAtTheEnd(10);
            myLL.AddElementAtTheEnd(20);
            myLL.AddElementAtTheEnd(30);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("at index " + i + " we have " + myLL.AccesByIndice(i));
            }

            int x = myLL.AccesByIndice(1);
            Console.WriteLine("At index 1 we have : " + x);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            myLL.InsertAtIndex(1000, 1);
            x = myLL.AccesByIndice(1);

            for (int i=0; i<5; i++)
            {
                Console.WriteLine("at index "+i+" we have " + myLL.AccesByIndice(i));
            }

            Console.WriteLine("Now, at index 1 we have : " + x);

            myLL.NextElement(1000);

            myLL.PreviousElement(1000);
            

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            /* MyList<int> myInts = new MyList<int>();
             myInts.Ajouer(2);
             myInts.Ajouer(4);
             myInts.Ajouer(8);
             myInts.Ajouer(16);

             MyList<string> myStrs = new MyList<string>();
             myStrs.Ajouer("Oxana");
             myStrs.Ajouer("Vira");
             myStrs.Ajouer("Anna");
             myStrs.Ajouer("Alisa");






             int x = 0; 
             x = myInts.GetValeur(2);

             string x_str = null; 
             x_str = myStrs.GetValeur(2);


             Console.WriteLine("My myInts type is " + myInts.GetType());
             Console.WriteLine("I should have 8 at index=2, so do i? x=" + x);
             Console.WriteLine("My myStr type is " + myStrs.GetType());
             Console.WriteLine("I should have Anna at index=2, so do i? x=" + x_str);







             /* int a = 7;
              string b = "sky";
              double c = 2.9;

              BlaBla(a, b);
              BlaBla(b, a);
              BlaBla(b, c);*/





            /* Dictionary<int, string> mine = new Dictionary<int, string>();
            mine.Add(100, "Oxana");
            mine.Add(200, "Vira");
            string oxana = mine[100];*/


            /* int a = 9;
             double b = 1.7;
             string c = "Oxana";

             Afficheur(a);
             Afficheur(b);
             Afficheur(c);*/


            /*string a_str = "noir";
            string b_str = "blanc";

            Console.WriteLine("Before fake permutation: a_str: " + a_str + "  b_str=" + b_str);

            PermutingNoRef(a_str, b_str);
            Console.WriteLine("After fake permutation: a_str: " +a_str+"  b_str="+ b_str);

            Console.WriteLine("Before real permutation: a_str: " + a_str + "  b_str=" + b_str);
           
            Permuting(ref a_str, ref b_str);
            Console.WriteLine("After real permutation: a_str: " + a_str + "  b_str=" + b_str);*/


            Console.ReadLine();
        }
    }
}
