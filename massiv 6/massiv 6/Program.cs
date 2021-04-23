using System;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 1, 12, 9, 15, 72 };



            int i;

            for (i = mass.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(mass[i]);
            }

            Console.ReadKey();


            /*int[] mass = { 1, 12, 9, 15, 72 };
            int[] massreverse = new int[5];
            int j = 0;
            int i;
            for (i = mass.Length - 1; i <= 0; i--)
            {

                mass[i] = massreverse[j];
                j++;
                Console.WriteLine(massreverse[j]);
            }

            Console.ReadKey(); */


        }
    }
}
