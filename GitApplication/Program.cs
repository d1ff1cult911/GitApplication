using System;

namespace GitApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void MatrixA(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Random rnd = new Random();
            
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    int n = rnd.Next(1, 100);
                    if (n %2==0)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write("1 ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
