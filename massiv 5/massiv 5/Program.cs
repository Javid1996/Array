using System;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite dlinu massiva");
            int length = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            int[] mass = new int[length];

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("vvedite element massiva");
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < mass.Length; j++)
            {
                if (j % 2 != 0)
                {
                    counter = counter + mass[j];
                }
            }




            /*  for (int j = 1; j < mass.Length;j=j+2)
            {
               
                counter = counter + mass[j];
            }*/
            Console.WriteLine(counter);
            Console.ReadKey();
        }

    }
}


