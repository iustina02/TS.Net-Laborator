using System;
using System.Threading;

namespace MultithreadingApplication
{
    class ThreadCreationProgram
    {
        public static void IsPrime_1()
        {
            int n = 86231234;

            Console.WriteLine("Start fir: thread_1 " + DateTime.Now.ToString("hh:mm:s:ms") + " . Numarul natural dat = " + n.ToString());


            bool prime = true;
            int nr_prim = 0;
            for (int i = n - 1; i > 1; i--)
            {
                prime = true;
                if (i <= 1)
                    prime = false;
                else if (i % 2 == 0)
                    prime = false;

                int N = (int)(Math.Sqrt(i) + 0.5);

                for (int j = 3; j <= N; j += 2)
                    if (i % j == 0)
                        prime = false;

                if (prime == true)
                {
                    nr_prim = i;
                    break;
                }
            }

            Console.WriteLine("End fir: thread_1 " + DateTime.Now.ToString("hh:mm:s:ms") + " . Numarul prim = " + nr_prim);

        }

        public static void IsPrime_2()
        {
            int n = 86231234;
            
            Console.WriteLine("Start fir: thread_2 " + DateTime.Now.ToString("hh:mm:s:ms") + " . Numarul natural dat = " + n.ToString());


            int prime;
            int nr_prim = 0;
            for(int i=  n-1; i > 1; i--)
            {
                prime = 1;
                if (i % 2 == 0)
                    prime = 0;
                for(int j = 3; j < i; j++)
                {
                    if (i % j == 0)
                        prime = 0;
                }
                if (i == 2)
                    prime = 1;
                if(prime == 1)
                {
                    nr_prim = i;
                    break;
                }

            }
            Console.WriteLine("End fir: thread_2 " + DateTime.Now.ToString("hh:mm:s:ms") + " . Numarul prim = " + nr_prim.ToString());

        }

        static void Main(string[] args)
        {
//          Console.Write("Alege un numar: ");
//            int n = int.Parse(Console.ReadLine());

            Thread thread_1 = new Thread(new ThreadStart(IsPrime_1));
            Thread thread_2 = new Thread(new ThreadStart(IsPrime_2));

            thread_1.Start();
            Console.WriteLine("Iesire temporara fir thread_1 " + DateTime.Now.ToString("hh:mm:s:ms"));
            thread_2.Start();
            Console.WriteLine("Iesire temporara fir thread_2 " + DateTime.Now.ToString("hh:mm:s:ms"));


        }

    }
}