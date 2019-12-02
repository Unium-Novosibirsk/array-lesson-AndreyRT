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
        public Array(int[] _Value)
        {
            Size = _Value.Length;
            Value = new int[_Value.Length];
            for (int j = 0; j < _Value.Length; j++)
                Value[j] = _Value[j];
        }
        public Array()
        {
            Value = new int[0];
            Size = 0;
        }
        public int Summ()
        {
            int summ = 0;
            for (int i = 0; i < Value.Length; i++)
                summ += Value[i];
            return summ;
        }
        public int Min()
        {
            int min = Value[0];
            for (int i = 0; i < Value.Length; i++)
                if (min > Value[i])
                    min = Value[i];
            return min;
        }
        public long Multiplication()
        {
            long multiplication = 1;
            for (int i = 0; i < Value.Length; i++)
                multiplication *= Value[i];
            return multiplication;
        }
        public int Max()
        {
            int max = 0;
            for (int i = 0; i < Value.Length; i++)
                if (max < Value[i])
                    max = Value[i];
            return max;
        }
        public void Print()
        {
            Console.Write("Array = ");
            for (int i = 0; i < Value.Length; i++)
                Console.Write(Value[i] + " ");
        }
        public int Find(int val)
        {
            for (int i = 0; i < Value.Length; i++)
                if (Value[i] == val)
                    return i;
            return -1;
        }
        public void RemoveByIndex(int index1)
        {
            if (index1 < 0 || index1 > Value.Length)
                throw new IndexOutOfRangeException();
            int[] arr = new int[Value.Length - 1];
            for (int i = 0; i < index1; i++)
                arr[i] = Value[i];
            for (int i = index1; i < Value.Length - 1; i++)
                arr[i] = Value[i + 1];
            Value = arr;
        }
        public int Get(int index)
        {
            if (index < 0 || index >= Value.Length)
                throw new IndexOutOfRangeException();
            else
                return Value[index];
        }
        public void Set(int index, int val)
        {
            if (index < 0 || index >= Value.Length)
                throw new IndexOutOfRangeException();
            else
                Value[index] = val;
        }
        public void BubbleSort()
        {
            int another = 0; ;
            for (int i = 0; i < Value.Length; i++)
                for (int j = i + 1; j < Value.Length; j++)
                    if (Value[i] > Value[j])
                    {
                        another = Value[i];
                        Value[i] = Value[j];
                        Value[j] = another;
                    }
        }
    }
}
