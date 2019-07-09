using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Дана функция у = 7х * 2 – 2х + 8");
            Console.WriteLine("Введите значение х: ");
            double x = double.Parse(Console.ReadLine());
            double y = 7 * x * 2 - 2 * x + 8;
            Console.WriteLine("Значение функции = " + y);
            Console.ReadKey();

            //задание 2
            Console.WriteLine("Введите радиус окружности");
            double radius = double.Parse(Console.ReadLine());
            double length = 2 * Math.PI * radius;
            double S = Math.PI * radius * radius;
            Console.WriteLine("Длина окружности равна {0}, площадь круга равна {1}", length, S);
            Console.ReadKey();

            //задание 3
            Console.WriteLine("Введите расстояние в сантиметрах: ");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("В этом расстоянии {0} полных метра", distance / 100);
            Console.ReadKey();

            //задание 4
            int weeks = 234 / 7;
            Console.WriteLine("С некоторого момента прошло {0} недель", weeks);
            Console.ReadKey();

            //задание 5
            Console.WriteLine("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("В данном числе {0} десятков ", number / 10);
            Console.WriteLine("В данном числе {0} едениц ", number % 10);
            int sum = 0;
            int composition = 1;
            while (number != 0)
            {
                sum += number % 10;
                composition *= number % 10;
                number /= 10;
            }
            Console.WriteLine("Сумма цифр в числе {0} ", sum);
            Console.WriteLine("Произведение цифр в числе {0} ", composition);
            Console.ReadKey();

            //задание 6
            Console.WriteLine("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int composition = 1;
            while (number != 0)
            {
                sum += number % 10;
                composition *= number % 10;
                number /= 10;
            }
            Console.WriteLine("Сумма цифр в числе {0}, произведение цифр в числе {1} ", sum, composition);
            Console.ReadKey();

            //задание 7
            int a = 4, b = 5, c = 6;
            int x = 100 * a + 10 * c + b;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
