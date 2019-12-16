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
            Array Array1 = new Array();
            Array Array2 = new Array(Array1);
            /*
            Console.WriteLine("Summ of args = " + Array1.Summ());
            Console.WriteLine("Max value of args = " + Array1.Max());
            Console.WriteLine("Min value of args = " + Array1.Min());
            Console.WriteLine("Multiplication of args = " + Array1.Multiplication());
            Console.WriteLine("Задайте значение для поиска");
            Console.WriteLine("индекс = " + Array1.Find(int.Parse(Console.ReadLine())));
            Console.WriteLine("Задайте значение индекса искомой переменной");
            Console.WriteLine(Array1.Get(int.Parse(Console.ReadLine())));
            Console.WriteLine("Задайте значение индекса для изменения значения и его новое значение");
            Array1.Set(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Array1.Print();
            Console.WriteLine("Задайте индекс для удаления значения");
            Array1.RemoveByIndex(int.Parse(Console.ReadLine()));
            Array1.Print();
            Console.WriteLine("Задайте значение для проверки его наличия");
            Console.WriteLine(Array1.Chek(int.Parse(Console.ReadLine())));
            Console.WriteLine();
            */
            Console.WriteLine("Выберите тип сортировки");
            Console.WriteLine("1 - BubbleSort");
            Console.WriteLine("2 - SelectionSort");
            Console.WriteLine("3 - InsertionSort");
            short interfasevalue = short.Parse(Console.ReadLine());
            Console.Write("Сортировка - ");
            if (interfasevalue == 1)
                Array1.BubbleSort();
            else if (interfasevalue == 2)
                Array1.SelectionSort();
            else if (interfasevalue == 3)
                Array1.InsertionSort();
            Array1.Print();
            Array2.Min();
            Array2.Print();
            Console.ReadKey();
        }
    }
}