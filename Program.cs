using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
             DisplayPar(5);

            Sum(862);
            Console.WriteLine(CalculateFactorial(5));
            Console.ReadKey();
        }
        public static void DisplayPar(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("*");
                    
                }

                Console.WriteLine("\n");
            }
            
        }
                

          public static void Sum(int n)
        {
            int sum = 0;
              while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits of the number is {0}",sum);
            Console.ReadKey();
        }

        public static int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * CalculateFactorial(n - 1);

            
        }
    }
}
