namespace TestGenericMaximum
{
    public class TestMaximumInt
    {
        [Test]
        public void maxnumberAtPos1_returnSame()
        {
            int a = 3, b = 2, c = 1;
            Core_Concept_Generics.PrintArray<int> printInt = new Core_Concept_Generics.PrintArray<int>(a,b,c);
            var output = printInt.showMaximum();
            Assert.AreEqual(a, output);
        }
        [Test]
        public void maxnumberAtPos2_returnSame()
        {
            int a = 3, b = 4, c = 2;
            Core_Concept_Generics.PrintArray<int> printInt = new Core_Concept_Generics.PrintArray<int>(a,b,c);
            var output = printInt.showMaximum();
            Assert.AreEqual(b, output);
        }
        [Test]
        public void maxnumberAtPos3_returnSame()
        {
            int a = 8, b = 9, c = 10;
            Core_Concept_Generics.PrintArray<int> printInt = new Core_Concept_Generics.PrintArray<int>(a,b,c);
            var output = printInt.showMaximum();
            Assert.AreEqual(c, output);
        }
    }
}