namespace TestGenericMaximum
{
    public class TestMaximumInt
    {
        [Test]
        public void maxnumberAtPos1_returnSame()
        {
            int[] array_Int = {5,4,3,2,1};
            Core_Concept_Generics.PrintArray<int> printInt = new Core_Concept_Generics.PrintArray<int>(array_Int);
            var output = printInt.showMaximum();
            Assert.AreEqual(array_Int[4], output);
        }
    }
}