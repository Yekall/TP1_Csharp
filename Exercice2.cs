using System;

namespace TP1_Application
{
    class Exercice2
    {
        public static void Ex2_1()
        {
            for (int i = 2; i <= 1000; i++)
            {
                if (VerifPrime(i))
                {
                    Console.WriteLine(i);
                }

            }
        }

        public static bool VerifPrime(int n)
        {
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        public static void Ex2_2(int n)
        {
            long a = 0;
            long b = 1;
            long c = 0;
            for (int i = 0; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }

    public static void Ex2_3(int n,int i)
        {
            if (i <= 25)
            {
                n = n * i;
                i++;
                Ex2_3(n,i);
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }