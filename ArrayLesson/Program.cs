using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте массив");
            var str = Console.ReadLine();
            int[] Array0 = str.Split(' ').Select(int.Parse).ToArray();
            Array Array1 = new Array(Array0);
            Array1.BubbleSort();
            Array1.Print();
            Console.ReadKey();
        }
    }
}
