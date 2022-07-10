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
            double[] array_Double = { 5.5,4.4,3.3,2.2,1.1};
            Core_Concept_Generics.PrintArray<double> printDouble = new Core_Concept_Generics.PrintArray<double>(array_Double);
            var output = printDouble.showMaximum();
            Assert.AreEqual(array_Double[4], output);
        }
    }
}
