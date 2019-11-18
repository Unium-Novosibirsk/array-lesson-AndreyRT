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
            try
            {
                Console.WriteLine("Задайте индекс для удаления значения");
                int index0 = int.Parse(Console.ReadLine());
                Array1.RemoveByIndex(index0);
                Console.WriteLine();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("input is incorrect");
            }
            Console.ReadLine();
        }
    }
}
