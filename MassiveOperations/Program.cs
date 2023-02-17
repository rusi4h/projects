using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            practice();
        }
        private static void massiverange()
        {
            int[] massive = Enumerable.Range(6, 10).ToArray(); // Filling an array with 10 elements starting from 6
            int len = massive.Length;
            for (int i = 0; i < len; i++) // Array iteration
            {
                Console.WriteLine(massive[i]);
            }
        }
        private static void practice()
        {
            Console.Write("Введите количество элементов в массиве : "); // Enter the number of elements in the array
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] massive = new int[n];
            for (int i = 0; i < n; i++) // Inserting elements into an array
            {
                Console.Write("Введите " + i + " элемент массива : ");
                massive[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = n - 1; i > -1; i--) // Array output in reverse order
            {
                Console.WriteLine(massive[i]);
            }
            for (int i = 0; i < massive.Length; i++) // Sum of even array elements
            {
                if (massive[i] % 2 == 0)
                {
                    sum += massive[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма четных элементов массива = " + sum);
            Console.WriteLine();
            Console.WriteLine("Наименьший элемент массива = " + massive.Min()); // Print the smallest element of an array
        }
    }
}
