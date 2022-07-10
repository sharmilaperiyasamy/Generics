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
            string a = "Peach", b = "Apple", c = "Banana";
            Core_Concept_Generics.PrintArray<string> printString = new Core_Concept_Generics.PrintArray<string>(a,b,c);
            var output = printString.showMaximum();
            Assert.AreEqual(a, output);
        }
        [Test]
        public void maxnumberAtPos2_returnSame()
        {
            string a = "Apple", b = "Peach", c = "Banana";
            Core_Concept_Generics.PrintArray<string> printString = new Core_Concept_Generics.PrintArray<string>(a, b, c);
            var output = printString.showMaximum();
            Assert.AreEqual(b, output);
        }
        [Test]
        public void maxnumberAtPos3_returnSame()
        {
            string a = "Banana", b = "Apple", c = "Peach";
            Core_Concept_Generics.PrintArray<string> printString = new Core_Concept_Generics.PrintArray<string>(a, b, c);
            var output = printString.showMaximum();
            Assert.AreEqual(c, output);
        }
    }
}
