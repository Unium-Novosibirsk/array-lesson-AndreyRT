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
            Array1.Summ();
            Array1.Max();
            Array1.Min();
            Array1.Multiplication();
            int s = Array1.Summ();
            int M1 = Array1.Max();
            int M2 = Array1.Min();
            long M3 = Array1.Multiplication();
            Console.WriteLine("Summ of args = " + s);
            Console.WriteLine("Max value of args = " + M1);
            Console.WriteLine("Min value of args = " + M2);
            Console.WriteLine("Multiplication of args = " + M3);
            Console.WriteLine("Задайте значение для поиска");
            int finding = int.Parse(Console.ReadLine());
            Array1.Find(finding);
            int Ind = Array1.Find(finding);
            Console.WriteLine("индекс = " + Ind);
            Console.WriteLine("Задайте значение индекса искомой переменной");
            int indexfind = int.Parse(Console.ReadLine());
            Array1.Get(indexfind);
            int z = Array1.Get(indexfind);
            Console.WriteLine(z);
            Console.WriteLine("Задайте значение индекса для изменения значения и его новое значение");
            int indexchange = int.Parse(Console.ReadLine());
            int valchange = int.Parse(Console.ReadLine());
            Array1.Set(indexchange, valchange);
            Array1.Print();
            Console.WriteLine();
            Console.WriteLine("Задайте индекс для удаления значения");
            int index0 = int.Parse(Console.ReadLine());
            Array1.RemoveByIndex(index0);
            Array1.Print();
            Console.WriteLine();
            Console.Write("Сортировка - ");
            Array1.BubbleSort();
            Array1.Print();
            Console.ReadKey();
        }
    }
}