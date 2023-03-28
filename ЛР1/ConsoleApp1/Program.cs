using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double avg;
            int length = 5;
            int[] x = new int[length];
            Console.WriteLine("Введите 5 целых чисел:");
            for (int i = 0; i < length; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + x[i];
            }
            avg = sum / x.Length;
            Console.WriteLine($"Cреднее арифметическое = {avg}");
            Console.ReadLine();
        }
    }
}
