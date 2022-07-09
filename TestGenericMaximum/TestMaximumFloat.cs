using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenericMaximum
{
    public class TestMaximumFloat
    {
        [Test]
        public void maxnumberAtPos1_returnSame()
        {
            double a = 3.3, b = 2.2, c = 1.1;
            Core_Concept_Generics.PrintArray print = new Core_Concept_Generics.PrintArray();
            var output = print.toPrintMaximum_double(a, b, c);
            Assert.AreEqual(a, output);
        }
        [Test]
        public void maxnumberAtPos2_returnSame()
        {
            double a = 3.3, b = 4.4, c = 2.2;
            Core_Concept_Generics.PrintArray print = new Core_Concept_Generics.PrintArray();
            var output = print.toPrintMaximum_double(a, b, c);
            Assert.AreEqual(b, output);
        }
        [Test]
        public void maxnumberAtPos3_returnSame()
        {
            double a = 8.8, b = 9.9, c = 10.0;
            Core_Concept_Generics.PrintArray print = new Core_Concept_Generics.PrintArray();
            var output = print.toPrintMaximum_double(a, b, c);
            Assert.AreEqual(c, output);
        }
    }
}
