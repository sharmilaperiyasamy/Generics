int[] array_int = { 5, 4, 3, 2, 1 };
double[] array_double = {5.5,4.4,3.3,2.2,1.1};
string[] array_string = { "Apple", "Peach", "Banana", "Cherry", "Mango" };

Core_Concept_Generics.PrintArray<int> printInt = new Core_Concept_Generics.PrintArray<int>(array_int);
Core_Concept_Generics.PrintArray<double> printDouble = new Core_Concept_Generics.PrintArray<double>(array_double);
Core_Concept_Generics.PrintArray<string> printString = new Core_Concept_Generics.PrintArray<string>(array_string);

Console.WriteLine("Maximum of array values : " + printInt.showMaximum());
Console.WriteLine("Maximum of array values : " + printDouble.showMaximum());
Console.WriteLine("Maximum of array values : " + printString.showMaximum());