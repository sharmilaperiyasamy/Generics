using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Concept_Generics
{
    public class PrintArray
    {

        //uc1 find maximum of three integers
        public int toPrintMaximum_Int(int value1, int value2, int value3)
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
        //uc2 find maximum of three float values
        public double toPrintMaximum_double(double value1, double value2, double value3)
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

        //uc3 find maximum of three string values
        public string toPrintMaximum_String(string value1, string value2, string value3)
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
    }
}
