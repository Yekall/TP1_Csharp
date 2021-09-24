using System;

namespace TP1_Application
{
    class Exercice4
    {
        int n = AskUserForParameter();

        int m = AskUserForParameter();
            for (int i = 0; i <= n;
        i++)
        {

            for (int j = 0; j < m + 1; j++)
            {
                if (((i == 0) | (i == n)) & ((j == 0) | (j == m)))
                {
                    Console.Write("0");
                }
                else if (((i == 0) | (i == n)) & ((j != 0) & (j != m)))
                {
                    Console.Write("-");
                }
                else if (((i != 0) & (i != n)) & ((j == 0) | (j == m)))
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine("");
        }
    }
}