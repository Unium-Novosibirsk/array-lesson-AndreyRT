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
        public void BubbleSort()
        {
            int another = 0; ;
            foreach (int i in Value)
                for (int j=i+1; j<Value.Length; j++)
                {
                    if (Value[i] > Value[j])
                    {
                        another = Value[i];
                        Value[i] = Value[j];
                        Value[j] = another;
                    }
                }
        }
    }
}
