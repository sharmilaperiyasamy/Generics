Core_Concept_Generics.PrintArray<int> printInt = new Core_Concept_Generics.PrintArray<int>(11, 22, 33);
Core_Concept_Generics.PrintArray<double> printDouble = new Core_Concept_Generics.PrintArray<double>(1.1, 2.2, 3.3);
Core_Concept_Generics.PrintArray<string> printString = new Core_Concept_Generics.PrintArray<string>("Apple", "Peach", "Banana");

Console.WriteLine("Maximum of Three integer values : " + printInt.showMaximum());
Console.WriteLine("Maximum of Three float values : " + printDouble.showMaximum());
Console.WriteLine("Maximum of Three String values : " + printString.showMaximum());