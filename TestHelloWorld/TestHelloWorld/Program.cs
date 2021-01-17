using System;
using System.Collections.Generic;

namespace TestHelloWorld
{
    class MainClass
    {

        static int CalculSommeEntiers(int borneMin, int borneMax)
        {
            int resulat = 0;
            for (int i = borneMin; i <= borneMax; i++)
            {
                resulat += i;
            }
            return resulat;
        }

        static double CalculAv(List<double> doubles)
        {
            double res = 0;
            for (int i = 0; i < doubles.Count; i++)
            {
                res = res + doubles[i];
                Console.WriteLine("doubles[i] at i= " + i + " is " + res);
            }

            return res / (doubles.Count);
        }


        static int Multiples()
        {

            List<int> resList3 = new List<int>();
            List<int> resList5 = new List<int>();

            for (int i = 0; i <= 100; i = i + 3)
            {
                resList3.Add(i);
            }

            for (int i = 0; i <= 100; i = i + 5)
            {
                resList5.Add(i);
            }


            int somme = 0;
            foreach (int m3 in resList3)
            {
                foreach (int m5 in resList5)
                {
                    if (m3 == m5)
                    {
                        somme = somme + m3;
                    }
                }
            }

            return somme;
        }



        static int Fibonacci (int member)
        {
            int[] Fibo = new int[member];
            Fibo[0] = 0;
            Fibo[1] = 1;


            for (int i = 2; i<member; i++)
            {
                Fibo[i] = Fibo[i - 2] + Fibo[i - 1];
            }


            return Fibo[member-1];
        }


        static int FibonacciList(int member)
        {
            List<int> Fibo = new List<int>();
            Fibo.Add(0);
            Fibo.Add(1);



            for (int i = 2; i < member; i++)
            {
                int res = Fibo[i - 2] + Fibo[i - 1];
                Fibo.Add(res);
            }


            return Fibo[member - 1];
        }





        public static void Main(string[] args)
        {
            int res1 = CalculSommeEntiers(2, 5);
            List<double> res2List = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            Console.WriteLine("List count is = " + res2List.Count);
            double res2 = CalculAv(res2List);
            Console.WriteLine("Result1 is = " + res1);
            Console.WriteLine("Result2 is = " + res2);
            Console.WriteLine(Multiples());
            Console.WriteLine("Fibo is " + Fibonacci(10));
            Console.WriteLine("FiboLst is " + FibonacciList(10));

            Console.WriteLine("Put number between 1 and 100");
            int tries = 0;
            bool found = false;
            int nbToGuess = new Random().Next(1,100);

            while (!found)
            {
                string inputString = Console.ReadLine();
                int input;
                if (int.TryParse(inputString, out input))
                {
                    tries++;
                    if (input == nbToGuess)
                    {
                        found = true;
                        Console.WriteLine("Bravo! It took you " + tries + " tries");
                    }

                    else
                    {
                        if (input > nbToGuess)
                        {
                            Console.WriteLine("Your input is bigger than secret");
                        }

                        else
                        {
                            Console.WriteLine("Your input is less than secret");
                        }
                    }


                }

                else {
                    Console.WriteLine("Wrong input " + input);
                }
            }
                


        }

    }
}

