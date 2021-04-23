using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite dlinu massiva");
            int d = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[d];
            for (int j = 0; j < mass.Length; j++)
            {

                Console.WriteLine($"vvedite element massiva {j + 1}");
                mass[j] = Convert.ToInt32(Console.ReadLine());

            }

            int counter = mass[0];

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < counter)
                {
                    counter = mass[i];
                }

            }

            Console.WriteLine($"minimalnoye znaceniye ravno  {counter}");
            Console.ReadKey();

        }
    }
}
