using System;

namespace TP1_Application
{
    class Exercice1
    {
        public static void Ex1_1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Table of ", i);
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("{0}x{1}={2}", i, j, (i * j));
                }
            }
        }

        public static void Ex1_2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Table of ", i);
                for (int j = 0; j <= 10; j++)
                {
                    if (i * j % 2 == 1)
                    {
                        Console.WriteLine("{0}x{1}={2}", i, j, (i * j));
                    }
                }
            }
        }

        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static void Ex1_3()
        {
            int table = AskUserForParameter();
            Console.WriteLine("Table of ", table);
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("{0}x{1}={2}", table, j, (table * j));
            }
        }
    }
}