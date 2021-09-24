using System;


namespace TP1_Application
{
    class Program
    {
        public static void Ex1_1()
        {
            for (int i=0; i<=10;i++){
                Console.WriteLine("Table of ", i);
                for (int j=0; j<=10;j++){
                    Console.WriteLine("{0}x{1}={2}",i,j,(i*j));
                }
            }
        }
        public static void Ex1_2()
        {
            for (int i=0; i<=10;i++){
                Console.WriteLine("Table of ", i);
                for (int j=0; j<=10;j++){
                    if (i*j % 2 == 1 )
                    {
                        Console.WriteLine("{0}x{1}={2}",i,j,(i*j));
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
                for (int j=0; j<=10;j++){
                    Console.WriteLine("{0}x{1}={2}",table,j,(table*j));
                }
        }

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
            for (int i=2; i <= n-1; i++)
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
                    Console.WriteLine(10/PowerFunction(i));
                }
                catch 
                {
                    Console.WriteLine("C'est dla D");
                    
                }
            }
        }

        public static void Ex4()
        {
            int n = AskUserForParameter();
            int m = AskUserForParameter();
            for (int i = 0; i <= n; i++)
            {
                
                for (int j = 0; j < m+1; j++)
                {
                    if (((i == 0)|(i == n))  & ((j==0)|(j==m)))
                    {
                        Console.Write("0");
                    }
                    else if (((i == 0)|(i== n)) & ((j!=0)&(j!=m)))
                    {
                        Console.Write("-");
                    }
                    else if (((i != 0)&(i!= n)) & ((j==0)|(j==m)))
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

       
            

            
            
        
        
        static void Main(string[] arg)
        {
            
            Ex1_1();
            Ex1_2();
            Ex1_3();
            
            Ex2_1();
            Ex2_2(10);
            Ex2_3(1,1);
            
            Ex3();
            
            Ex4();
            
        }
    }
}