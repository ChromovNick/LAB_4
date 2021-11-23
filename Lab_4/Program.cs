using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    sum += (2 * i) - 1;
                    Console.WriteLine("Квадрат числа {0} равен {1}", i, sum);
                }
            }

            else
            {
                Console.WriteLine("Число N=0!");
            }
         
            Console.ReadKey();
        }
    }
}
