
using System;

namespace massiv_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполнить массив из 20 элементов числами Фибоначчи");
            int[] fib = new int[20];
            int i;
            fib[0] = 0;
            fib[1] = 1;
            for (i = 2 ; i < fib.Length ;i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (i = 0; i < fib.Length; i++)

            { 
                Console.WriteLine(fib[i]); 
            
            }

            Console.ReadKey();
        }
    }
}
