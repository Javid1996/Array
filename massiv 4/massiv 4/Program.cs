using System;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("vvedite dlinu massiva");
                int d = Convert.ToInt32(Console.ReadLine());
                int[] mass = new int[d];
                for (int j = 0; j < mass.Length; j++)
                {

                    Console.WriteLine($"vvedite {j + 1} element massiva");
                    mass[j] = Convert.ToInt32(Console.ReadLine());

                }
                int counter2 = 0;
                int counter = mass[0];

                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] > counter)
                    {
                        counter = mass[i];
                        counter2 = i;
                    }


                }

                Console.WriteLine($"maksimalnoye znaceniye massiva prinadlejit indeksu  {counter2}");
                Console.ReadKey();

            }
        }
    }
}

