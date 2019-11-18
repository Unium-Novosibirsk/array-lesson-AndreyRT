using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    public class Array
    {
        public int Size { get; set; }
        private int[] Value;
        public Array(int[] _Value)
        {
            Size = _Value.Length;
            Value = new int[_Value.Length];
            for (int j = 0; j < _Value.Length; j++)
            {
                Value[j] = _Value[j];
            }
        }
        public Array()
        {
            Value = new int[0];
            Size = 0;
        }
        public int GetByIndex(int index)
        {
            if (index > 0 && index <= Value.Length)
                return Value[index];
            else
                throw new IndexOutOfRangeException();
        }
        public void SetByIndex(int index, int val)
        {
            if (index > 0 && index <= Value.Length)
                Value[index] = val;
            else
                throw new IndexOutOfRangeException();
        }
    }
}

