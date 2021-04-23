using System;

namespace massiv8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int[] mass = { 1, 2, 3, 4, };

            
            int n2 = mass.Length / 2;

            while (n1 < mass.Length / 2)
            {
                int temp = mass[n1];
                mass[n1] = mass[n2];
                mass[n2] = temp;

                n1++; n2++;
            }

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i]);
            }
            Console.ReadLine();
        }
    }
}
