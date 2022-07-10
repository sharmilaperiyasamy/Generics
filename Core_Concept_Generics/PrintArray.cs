using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Concept_Generics
{
    public class PrintArray<T> where T : IComparable
    {
        public T[] value;
        public PrintArray(T[] value)
        {
            this.value = value;
        }
        //uc4 more than 3 integers and to use function
        public static T[] sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }

        public static T toPrintMaximum(params T[] value)
        {
            var sorted_values = sort(value);
            return sorted_values[value.Length - 1];
        }
        public T showMaximum()
        {
            var Result = PrintArray<T>.toPrintMaximum(this.value);
            return Result;
        }
        //uc7 to print the max to std out using generic method
        public void printMax()
        {
            var max = toPrintMaximum(this.value);
            Console.WriteLine("Maximum value is: " + max);
        }
    }
}
