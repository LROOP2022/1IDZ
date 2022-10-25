using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class LR1
    {
        public static void DoTask()
        {
            Console.Write("Введите количество чисел ");
            int n = int.Parse(Console.ReadLine());
            float [] numb = new float[n];
            float [] numb2 = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите "+(i+1)+" число ");
                numb[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Результирующая последовательность: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    numb2[i] += numb[j];
                }
                Console.WriteLine(numb2[i]);
            }
        }
    }
}
