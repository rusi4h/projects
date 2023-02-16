using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rusi4hMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            block6();
        }
        private static void block1()
        {
            int[] massive = new int[10];
            massive[0] = 1;
            massive[1] = 12;
            massive[2] = 143;
            massive[3] = 115;
            massive[4] = 13467;
            massive[5] = 1346;
            for (int i = 0; i <= massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }
        }
        private static void block2()
        {
            int[] massive = new int[8];
            massive[1] = 21253;
            massive[3] = 2531;
            massive[5] = 2123;
            massive[7] = 224;
            for (int i = 7; i >= 0; i--)
            {
                Console.WriteLine(massive[i]);
            }
        }
        private static void block3()
        {
            int[] massive = new int[6];
            massive[0] = 67;
            massive[2] = 88;
            massive[4] = 234;
            massive[5] = 99;
            for (int i = 0; i <= massive.Length; i++)
            {
                if (massive[i] % 2 == 0 & massive[i] != 0)
                {
                    Console.WriteLine(massive[i]);
                }
            }
        }
        private static void block4()
        {
            int[] massive = new int[10];
            massive[0] = 1;
            massive[1] = 12;
            massive[2] = 143;
            massive[3] = 115;
            massive[4] = 13467;
            massive[5] = 1346;
            for (int i = 0; i <= massive.Length; i += 2)
            {
                Console.WriteLine(massive[i]);
            }
        }
        private static void block5()
        {
            int[] massive = { 12, 78, 44, 78, 33, 47, 90, 20, 10 };
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % n == 0)
                {
                    sum += massive[i];
                }
            }
            Console.WriteLine(sum);
        } // Find the sum of array elements that are multiples of some given number.
        private static void block6()
        {
            int[] massive = { 0, 1, -2, 56, -3, -8, -66, 35};
            int sum = 0;
            for (int i = 1; i <= massive.Length - 1; i++)
            {
                sum += Math.Abs(massive[i]);
            }
            Console.WriteLine(sum);
        } // Sum of modules of array elements after the first element equal to zero.
        private static void block7()
        {

        }
    }
}
