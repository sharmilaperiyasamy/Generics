using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenericMaximum
{
    public class TestMaximumString
    {
        [Test]
        public void maxnumberAtPos1_returnSame()
        {
            string[] array_String = { "Peach","Apple","Banana","Cherry","Mango"};
            Core_Concept_Generics.PrintArray<string> printString = new Core_Concept_Generics.PrintArray<string>(array_String);
            var output = printString.showMaximum();
            Assert.AreEqual(array_String[4], output);
        }
    }
}
