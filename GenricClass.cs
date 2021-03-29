using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumberProject
{
   public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(value);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is = " + max);
        }

    }
}
