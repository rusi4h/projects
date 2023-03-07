using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivePrac6
{
    class Program
    {
        static void Main(string[] args)
        {
            task20();
        }
        private static void task1()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] > 0)
                {
                    massive[i] *= -1;
                    Console.WriteLine(massive[i]);
                }
            }
        }
        private static void task2()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            Console.Write("Введите число : ");
            int changenumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < changenumber)
                {
                    massive[i] = changenumber;
                    Console.WriteLine(massive[i]);
                }
            }
        }
        private static void task3()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            Console.Write("Введите границу От : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите границу До : ");
            int end = int.Parse(Console.ReadLine());
            for (int i = 0; i < massive.Length; i++)
            {
                if (start < massive[i] && massive[i] < end)
                {
                    massive[i] = 0;
                    Console.WriteLine(massive[i]);
                }
            }
        }
        private static void task4()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < 0 && massive[i] % 3 != 0)
                {
                    massive[i] *= -1;
                    Console.WriteLine(massive[i]);
                }
            }
        }
        private static void task5()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            Console.Write("Введите число : ");
            int indicativenumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < indicativenumber)
                {
                    massive[i] *= 2;
                    Console.WriteLine(massive[i]);
                }
            }
        }
        private static void task6()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            Console.WriteLine(massive.Average());
        }
        private static void task7()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            double sum = 0;
            int count = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < 0)
                {
                    sum += massive[i];
                    count += 1;
                }
            }
            Console.WriteLine(sum / count);
        }
        private static void task8()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            int count = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 2 != 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
        private static void task9()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            Console.Write("Введите границу От : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите границу До : ");
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (start < massive[i] && massive[i] < end)
                {
                    sum += massive[i];
                }
            }
            Console.WriteLine(sum);
        }
        private static void task10()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            int sum = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 9 == 0)
                {
                    sum += massive[i];
                }
            }
            Console.WriteLine(sum); // 0 т.к. элементов % 9 нет
        }
        private static void task11()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 55, 89, -33 };
            int count = 0;
            Console.Write("Введите границу 1 : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите границу 2 : ");
            int end = int.Parse(Console.ReadLine());
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < start && end > massive[i])
                {
                    count += 1;
                }
            }
            Console.WriteLine(count); // 7 и 8 = 4 элемента
        }
        private static void task12()
        {
            double[] massive = new double[8] { 1, 55, -10, 12, -8, 52, 89, -33 };
            double sum = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 2 == 0)
                {
                    sum += Math.Pow(massive[i], 2);
                }
            }
            Console.WriteLine(sum);
        }
        private static void task13()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 54, 89, -33 };
            Console.Write("Введите ориентировочное число = ");
            int indicativenumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] > indicativenumber)
                {
                    Console.WriteLine("Число под индексом " + i + " больше, чем ориентировочное число");
                }
            }
        }
        private static void task14()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 54, 89, -33 };
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 2 != 0)
                {
                    Console.WriteLine("Число под номером " + i + " является нечётным");
                }
            }
        }
        private static void task15()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 54, 89, -33 };
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 7 != 0)
                {
                    Console.WriteLine("Число под номером " + i + " является неделимой на 7");
                }
            }
        }
        private static void task16()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 54, 89, -33 };
            Console.Write("Введите границу 1 : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите границу 2 : ");
            int end = int.Parse(Console.ReadLine());
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < start && end > massive[i])
                {
                    Console.WriteLine("Число под номером " + i + " не входит в заданный интервал");
                }
            }
        }
        private static void task17()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 54, 89, -33 };
            int multiplication = 1;
            for (int i = 0; i < massive.Length; i++)
            {
                multiplication *= massive[i];
            }
            Console.WriteLine(multiplication > 99 && multiplication < 1000 ? "Трехзначное" : "Не трёхзначное");
        }
        private static void task18()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 54, 89, -33 };
            int summ = 1;
            for (int i = 0; i < massive.Length; i++)
            {
                summ += massive[i];
            }
            Console.WriteLine(summ > 9 && summ < 100 ? "Двухзначное" : "Не двухзначное");
        }
        private static void task19()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 54, 89, -33 };
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i + 1]);
                i++;
            }
        }
        private static void task20()
        {
            int[] massive = new int[8] { 1, 55, -10, 12, -8, 54, 89, -33 };
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] > 0)
                {
                    Console.WriteLine(massive[i]);
                    i++;
                }
            }
        }
    }
}
