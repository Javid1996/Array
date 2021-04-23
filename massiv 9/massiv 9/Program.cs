using System;

namespace massiv_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10] { 5, 12, 3, 7, 8, 24, 72, 13, 16, 45 };

            int thirdcup ;

            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        thirdcup = mass[i];
                        mass[i] = mass[j];
                        mass[j] = thirdcup;

                    }
                
                }

            }
            
                foreach (int i in mass)
               
                Console.WriteLine(i);

            Console.ReadKey();
        }


    }
}