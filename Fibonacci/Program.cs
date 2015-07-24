/*
 * Sequencia de Fibonacci Recursiva (Recursive Fibonacci Sequence)
 * 
 */

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if ( (n >= 1) && (n <= 10) )
            {
                Console.WriteLine("Fibonacci da sequencia de " + n + " números é: ");
                Fib(0, 1, 1, n);
                Console.Read();
            }
        }

        static void Fib(int y, int z, int cont, int numero)
        {           
            Console.WriteLine(y);
            if (cont < numero)
                Fib(z, y + z, cont + 1, numero);
        }
    }
}
