using System;

namespace TP1_Application
{
    class Exercice3
    {
        private static int PowerFunction(int x)
        {
            return (int) (Math.Pow(x, 2) - 4);
        }

        public static void Ex3()
        {
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    Console.WriteLine(10 / PowerFunction(i));
                }
                catch
                {
                    Console.WriteLine("C'est dla D");

                }
            }
        }
    }
}