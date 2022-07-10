using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Concept_Generics
{
    public class PrintArray<T> where T : IComparable
    {
        public T value1, value2, value3;
        public PrintArray(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }
        //uc4 find maximum of three values
        public static T toPrintMaximum(T value1, T value2, T value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0 ||
                value1.CompareTo(value2) >= 0 && value1.CompareTo(value3) > 0 ||
                value1.CompareTo(value2) > 0 && value1.CompareTo(value3) >= 0)
            {
                return value1;
            }
            else if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0 ||
               value2.CompareTo(value1) >= 0 && value2.CompareTo(value3) > 0 ||
               value2.CompareTo(value1) > 0 && value2.CompareTo(value3) >= 0)
            {
                return value2;
            }
            else
            {
                return value3;
            }
        }
        public T showMaximum()
        {
            T Result = PrintArray<T>.toPrintMaximum(this.value1, this.value2, this.value3);
            return Result;
        }
    }
}
