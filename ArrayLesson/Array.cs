using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    public class Array
    {
        public int Size { get; private set; }
        private int[] Value;
        public Array(Array array)
        {
            Array Array0 = array;
            Size = array.Size;
            Value = new int[array.Size];
            for (int j = 0; j < array.Size; j++)
                Value[j] = array[j];
        }
        public Array()
        {
            var str = Console.ReadLine();
            Value = str.Split(' ').Select(int.Parse).ToArray();
            Size = Value.Length;
        }
        public int this [int index]
        {
            get
            {
                return Get(index);
            }
            set
            {
                Set(index, value);
            }

        }
        public int Summ()
        {
            int summ = 0;
            for (int i = 0; i < Size; i++)
                summ += Value[i];
            return summ;
        }
        public int Min()
        {
            int min = Value[0];
            for (int i = 0; i < Size; i++)
                if (min > Value[i])
                    min = Value[i];
            return min;
        }
        public long Multiplication()
        {
            long multiplication = 1;
            for (int i = 0; i < Size; i++)
                multiplication *= Value[i];
            return multiplication;
        }
        public int Max()
        {
            int max = 0;
            for (int i = 0; i < Size; i++)
                if (max < Value[i])
                    max = Value[i];
            return max;
        }
        public void Print()
        {
            Console.Write("Array = ");
            for (int i = 0; i < Size; i++)
                Console.Write(Value[i] + " ");
            Console.WriteLine();
        }
        public int Find(int val)
        {
            for (int i = 0; i < Size; i++)
                if (Value[i] == val)
                    return i;
            return -1;
        }
        public void RemoveByIndex(int index1)
        {
            if (index1 < 0 || index1 > Value.Length)
                throw new IndexOutOfRangeException();
            int[] arr = new int[Size - 1];
            for (int i = 0; i < index1; i++)
                arr[i] = Value[i];
            for (int i = index1; i < Size - 1; i++)
                arr[i] = Value[i + 1];
            Value = arr;
        }
        public int Get(int index)
        {
            if (index < 0 || index >= Size)
                throw new IndexOutOfRangeException();
            else
                return Value[index];
        }
        public void Set(int index, int val)
        {
            if (index < 0 || index >= Size)
                throw new IndexOutOfRangeException();
            else
                Value[index] = val;
        }
        static void Swap(ref int firstarg, ref int secondarg)
        {
            int change = firstarg;
            firstarg = secondarg;
            secondarg = change;
        }
        public bool Chek(int val)
        {
            for (int i = 0; i < Size; i++)
                if (Value[i] == val)
                    return true;
            return false;
        }
        public void BubbleSort()
        {
            for (int i = 1; i < Size; i++)
                for (int j = Value.Length - 1; j > 0; j--)
                    if (Value[j - 1] > Value[j])
                        Swap(ref Value[j - 1], ref Value[j]);
        }
        public void SelectionSort()
        {
            for (int i = 0; i < Size; i++)
            {
                int minind = i;
                for (int j = i; j < Size; j++)
                    if (Value[minind] > Value[j])
                        minind = j;
                Swap(ref Value[i], ref Value[minind]);
            }
        }
        public void InsertionSort()
        {
            int change = 0;
            int index = 0;
            for (int i = 1; i < Size; i++)
            {
                index = 0;
                while (Value[index] <= Value[i] && index<i)
                    index++;
                change = Value[i];
                for (int j = i; j > index; j--)
                    Value[j] = Value[j - 1];
                Value[index] = change;
            }
        }
    }
}