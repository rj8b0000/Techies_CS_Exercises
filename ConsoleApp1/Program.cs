using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("**1. Temperature Converter **");
            Console.WriteLine("**2. Area of circle **");
            Console.WriteLine("**3. String Manipulation **");
            Console.WriteLine("**4. Sum of Integer Array **");
            Console.WriteLine("**5. Boolean Logic **");
            Console.WriteLine("**6. Void Methods **");
            Console.WriteLine("**7. Sum of two Program **");
            Console.WriteLine("**8. Returns Square of Entered Number **");
            Console.WriteLine("**9. Addition and Calculation **");
            Console.WriteLine("**10. Method Overloading **");
            Console.WriteLine("**11. Optional Parameters **");
            Console.WriteLine("**12. Named Arguments **");
            Console.WriteLine("**13. Params Arguments **");
            Console.WriteLine("**14. Out Parameter **");
            Console.WriteLine("**15. Array with new keyword **");
            Console.WriteLine("**16. Print First and Last Element of Array **");
            Console.WriteLine("**17. Modify and Print Elements of Array **");
            Console.WriteLine("**18. Looping Arrays with For Each Element **");
            Console.WriteLine("**19. Multi-Dimensional Array **");
            Console.WriteLine("**20. Jagged Arrays **");
            Console.WriteLine("**21. Ranges and Indices Array **");
            Console.WriteLine("**22. Add and Print Items from List **");
            Console.WriteLine("**23. Removing Items from List **");
            Console.WriteLine("**24. Create age Dictionary **");
            Console.WriteLine("**25. Dictionary Stock Check **");
            Console.WriteLine("**26. Looping Through Dictionary **");
            Console.WriteLine("**27. Constructor and Constructor Overloading **");
            
            Console.WriteLine("Enter The Program Case Number:");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TemperatureConvertor.Run();
                    break;
                case 2:
                    AreaOfCircle.Run();
                    break;
                case 3:
                    StringManipulation.Run();
                    break;
                case 4:
                    SumOfArray.Run();
                    break;
                case 5:
                    BooleanLogic.Run();
                    break;
                case 6:
                    VoidMethods.PrintHelloWorld();
                    break;
                case 7:
                    Console.WriteLine("The sum of two numbers is " + SumOfTwoNumber.Run(3, 5));
                    break;
                case 8:
                    Console.WriteLine("Enter the number to get its square");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The sum of two numbers is " + SquareOfEnteredNumber.Run(num));
                    break;
                case 9:
                    int a, b, c;
                    Console.Write("Enter a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter c: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Addition is: " + AddAndCalc.Add(a, b) + " & Calculation is: " +
                                  AddAndCalc.Calc(a, b, c));
                    break;
                case 10:
                    int x, y, z;
                    Console.Write("Enter a: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter b: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter c: ");
                    z = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Addition of two number is: " + MethodOverloading.Add(x, y) +
                                  " Addition of three numbers is: " + MethodOverloading.Add(x, y, z));
                    break;
                case 11:
                    OptionalParameters.Greet("Rudraksh", "Hi");
                    OptionalParameters.Greet("Rudraksh");
                    OptionalParameters.Greet("World", "Greetings");
                    break;
                case 12:
                    int scenario;
                    Console.Write("Enter scenario: ");
                    scenario = Convert.ToInt32(Console.ReadLine());
                    NamedArguments.Run(scenario);
                    break;
                case 13:
                    ParamsArguments.SumAll(1, 2, 3);
                    ParamsArguments.SumAll(10);
                    ParamsArguments.SumAll();
                    ParamsArguments.SumAll(5, 5, 5, 5);
                    break;
                case 14:
                    int q, r;
                    bool result1 = OutParameter.Divide(10, 3, out q, out r);
                    bool result2 = OutParameter.Divide(17, 5, out q, out r);
                    bool result3 = OutParameter.Divide(10, 0, out q, out r);

                    Console.WriteLine("Result 1: " + result1);
                    Console.WriteLine("Result 2: " + result2);
                    Console.WriteLine("Result 3: " + result3);
                    break;
                case 15:
                    int[] numbers = new int[5];
                    Console.Write("Length of array: " + numbers.Length);
                    break;
                case 16:
                    int[] numbers2 = { 1, 2, 3, 4 };
                    PrintFirstAndLastElement.Run(numbers2);
                    break;
                case 17:
                    int[] numArr1 = { 10, 20, 30 };
                    int[] numArr2 = { 5, 15 };
                    Console.WriteLine("Num Array 1");
                    ModifyAndPrint.Run(numArr1);
                    Console.WriteLine("Num Array 2");
                    ModifyAndPrint.Run(numArr2);
                    break;
                case 18:
                    string[] names = { "John", "Bob", "Marie" };
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }

                    break;
                case 19:
                    MultiDimensionalArray.PrintGrid();
                    break;
                case 20:
                    JaggedArray.Run();
                    break;
                case 21:
                    int[] numArray3 = { 10, 20, 30 };
                    RangesAndIndices.GetLastTwoElements(numArray3);
                    break;
                case 22:
                    List<string> nameList = new List<string>{"Rudraksh", "Amit", "Peter"};
                    nameList.Add("John");
                    foreach (string name in nameList)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                case 23:
                    RemoveItemFromList.Run( ["John", "Bob", "Mary"], "Mary");
                    break;
                case 24:
                    var dict = CreateDictionary.CreateAgeDictionary();
                    dict.Add("Bob", 2);
                    dict.Add("Charlie", 3);
                    dict.Add("Den", 4);
                    dict.Add("James", 5);
                    Console.WriteLine(dict.Count);
                    Console.WriteLine(dict["Charlie"]);
                    break;
                case 25:
                    var invertory = new Dictionary<string, int> { { "Apple", 10 },{"Orange", 20 },{"Banana", 30 }, };
                    DictionaryStockCheck.GetValueSafely(invertory, "Apple");
                    DictionaryStockCheck.GetValueSafely(invertory, "Guvawa");
                    break;
                case 26:
                    static void PrintDictionary(Dictionary<string, int> dict)
                    {
                        foreach (var (key, value) in dict)
                        {
                            Console.WriteLine("Keys: " + key);
                            Console.WriteLine("Value: " + value);
                        }
                    }
                    PrintDictionary(new  Dictionary<string, int> { { "Apple", 10 },{"Orange", 20 },{"Banana", 30 }, });
                    break;
                case 27:
                    Person ob1 = new Person(name:"Alice");
                    Person ob2 = new Person(age:20, name:"Bob");
                    Console.WriteLine($"The name is {ob1.Name} and the age is {ob1.Age}");
                    Console.WriteLine($"The name is {ob2.Name} and the age is {ob2.Age}");
                    break;
                default:
                    Console.WriteLine("Invalid Case Entered");
                    break;

            }
        }
    }
}
