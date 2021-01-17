using System;
using System.Threading;

namespace Threads
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BankAcc accc = new BankAcc(10);
            Thread[] ts = new Thread[15];
            Thread.CurrentThread.Name = "main";

            for (int i=0; i<15; i++)
            {
                Thread t = new Thread(new ThreadStart(accc.Issue));
                t.Name = i.ToString();
                ts[i] = t;
            }


            for (int i =0; i<15; i++)
            {
                Console.WriteLine("Thread {0}  alive: {1}", ts[i].Name, ts[i].IsAlive);
                ts[i].Start();
                Console.WriteLine("Thread {0}  alive: {1}", ts[i].Name, ts[i].IsAlive);
            }

            Console.WriteLine("Current : " + Thread.CurrentThread.Priority);
            Console.WriteLine("Thread {0} ends", Thread.CurrentThread.Name);


            Console.ReadLine(); 
        }
        }

    class BankAcc {

        private Object accLock = new object();
        double Balance { get; set; }


        public BankAcc (double bal)
        {
            Balance = bal;
        }

        public double Withdrow (double amt)
        {
            if ((Balance-amt)<0)
            {
                Console.WriteLine("Not enough money");
                return Balance;
            }

            lock (accLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Your new balance is "+ (Balance-amt));
                    Balance -= amt;
                } return Balance;
            }
        }

        public void Issue()
        {
            Withdrow(1);
        }



    }
}
