using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciiterativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(10));
            Console.ReadKey();
        }

        static int fibonacci(int n)
        {
            int num0 = 0, num1 = 1, resultado = 0;

            if (n == 0) 
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            for (int i = 2; i <= n; i++)
            {
                resultado = num0 + num1;
                num0 = num1;
                num1 = resultado;
            }

            return resultado;

        }
    }
}
