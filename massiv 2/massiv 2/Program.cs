﻿using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину массива");
            int d = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[d];
            for (int j = 0; j < mass.Length; j++)
            {

                Console.WriteLine($" введите элемент массива {j + 1}");
                mass[j] = Convert.ToInt32(Console.ReadLine());

            }

            int counter = mass[0];

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > counter)
                {
                    counter = mass[i];
                }

            }

            Console.WriteLine($" максимальное значение равно  {counter}");
            Console.ReadKey();

        }
    }
}

