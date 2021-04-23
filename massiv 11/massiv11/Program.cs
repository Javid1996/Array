using System;

namespace massiv11
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1;
            string name2;
            int age1;
            int age2;

            Console.WriteLine("введите первое имя:");
            name1 = Console.ReadLine();



            while (name1.Trim().Length == 0)
            {
                Console.WriteLine("введите первое имя");
                name1 = Console.ReadLine();
            }

            Console.WriteLine($"имя первого человека: {name1} ");
            Console.WriteLine($" какой возраст у {name1} ?");
            age1 = Convert.ToInt32(Console.ReadLine());

            while (age1 <= 0 || age1 > 130)
            {
                Console.WriteLine($"введите правильный возраст для {name1} ");

                age1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{name1} , {age1} года(лет)");
            }



            Console.WriteLine("Теперь введите второе имя:");
            name2 = Console.ReadLine();



            while (name2.Trim().Length == 0)
            {
                Console.WriteLine("введите корректное имя");
                name2 = Console.ReadLine();
            }
            Console.WriteLine($" второго человека зовут {name2} ");
            Console.WriteLine($" введите возраст {name2} ");
            age2 = Convert.ToInt32(Console.ReadLine());

            while (age2 <= 0 || age2 > 130)
            {
                Console.WriteLine($"введите корректный возраст для {name2} ");

                age2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{name2}, {age2} года(лет)");
            }

            Console.WriteLine("человек с каким именем старше?");

            string older;
            older = Console.ReadLine();
            int years1;
            int years2;

            if (older == name1 && age1 > age2)
            {
                years1 = age1 - age2;
                Console.WriteLine($" Правильно, {name1} старше на {years1} лет");
            }

            else if (older == name1 && age1 < age2)
            {

                years1 = age2 - age1;
                Console.WriteLine($" Не правильно, {name1} младше на {years1} лет");
            }

            else if (older == name2 && age1 < age2)
            {
                years2 = age2 - age1;
                Console.WriteLine($"Правильно, {name2} старше на {years2} лет");
            }

            else if (older == name2 && age1 > age2)
            {
                years2 = age1 - age2;
                Console.WriteLine($" Не правильно, {name2} младше на {years2} лет");

            }

            else if (age1 == age2)
            {
                Console.WriteLine($"{name1} и {name2} ровестники");


                Console.ReadKey();

            }
        }

    }
}
