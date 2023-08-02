using System.Xml.Schema;
using System.IO;

namespace console_fundamentals_again;
class Program
{
    //main method control flow

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // string props and methods
        Console.WriteLine();
        string myString = "Hello ";
        Console.WriteLine("/" + myString + "/");
        Console.WriteLine(myString[1]);  // Outputs "e"
        Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
        Console.WriteLine(myString.Length);
        Console.WriteLine("/" + myString.TrimEnd(' ') + "/");
        
        // more string methods
        Console.WriteLine();
        string nameTest = "John Doe";
        Console.WriteLine(nameTest);
        int charPos = nameTest.IndexOf("D");
        string lastName = nameTest.Substring(charPos);
        Console.WriteLine(lastName);
        
        // if condition
        Console.WriteLine();
        int myAge = 25;
        int votingAge = 18;
        if (myAge >= votingAge) 
        {
        Console.WriteLine("Old enough to vote!");
        } 
        else 
        {
        Console.WriteLine("Not old enough to vote.");
        }

        // if else condition
        Console.WriteLine();
        DateTime time1 = DateTime.Now;
        if (time1.Hour > 20)
        {
            Console.WriteLine(value: "Good night");
        }
        else if (time1.Hour < 11)
        {
            Console.WriteLine("Good morning");
        }
        else
        {
            Console.WriteLine("Good day");
        }

        // ternary condition
        Console.WriteLine();
        DateTime time2 = DateTime.Now;
        string greeting2 = (time2.Hour < 11) ? "morning" : "hey";
        Console.WriteLine(greeting2);

        // switch cases
        Console.WriteLine();
        int day = 4;
        switch (day) 
        {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        }

        // custom method
        Console.WriteLine();
        TestMethod();

        // while loops in custom methods
        Console.WriteLine();
        PrintNumbers();
        Console.WriteLine();
        PrintEvenNumbers();
        Console.WriteLine();
        PrintEvenNumbersZero();

        // for loops nesting
        Console.WriteLine();
        for (int j = 100; j < 102; j++) 
        {
            Console.WriteLine("Outer loop " + j);

            for (int k = 1000; k < 1002; k++)
            {
                Console.WriteLine("Inner loop " + k);
            }
        }

        // foreach elements of an array
        Console.WriteLine();
        string[] carMakes = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string make in carMakes) 
        {
            Console.WriteLine(make);
        }

        // breaking loops
        Console.WriteLine();
        for (int y = 0; y < 5; y++)
        {
            if (y == 4)
            {
                break;
            }
            Console.WriteLine("You will see " + y);
        }
        Console.WriteLine("You will not see 4");
        Console.WriteLine();
        for (int y = 0; y < 5; y++)
        {
            if (y == 3)
            {
                Console.WriteLine("You missed 3");
                continue;
            }
            Console.WriteLine("You see " + y);
        }

        // arrays and loops
        Console.WriteLine();
        int[] array1 = { 1, 2, 3, 4};
        Console.WriteLine("Array is " + array1.Length + " long");
        for (int p = 0; p < array1.Length; p++)
        {
            Console.WriteLine(array1[p]);
        }
        Console.WriteLine("One more time");
        foreach (int item1 in array1)
        {
            Console.WriteLine(item1);
        }
        
        // sorting arrays
        Console.WriteLine();
        string[] carMakes2 = {"Volvo", "BMW", "Ford", "Mazda", "TOYOTA", "Volkswagen", "Audi", "Mercedes-Benz"}; 
        string[] carMakes3 = new string[8];
        Array.Copy(carMakes2, carMakes3, carMakes2.Length);
        Array.Sort(carMakes3);
        foreach (var item2 in carMakes2)
        {
            Console.WriteLine("Index of " + item2 + " is " + 
                Array.IndexOf(carMakes3, item2) + " now and it was " + 
                Array.IndexOf(carMakes2, item2)  + " before sorting");
        }

        // two-d arrays
        Console.WriteLine();
        int[,] numbers7 = { {1, 4, 2}, {3, 6, 8} };
        Console.WriteLine(numbers7[0, 2]);
        Console.WriteLine(numbers7[0, 0] + " before");
        numbers7[0, 0] = 5;
        Console.WriteLine(numbers7[0, 0] + " after");

        // two-d arrays and loops
        Console.WriteLine();
        int[,] numbers8 = { {1, 4, 2}, {3, 6, 8} };
        foreach (int k in numbers8)
        {
            Console.WriteLine(k);
        }
        
        Console.WriteLine();
        int[,] numbers9 = { {1, 4, 2}, {3, 6, 8} };
        for (int r = 0; r < numbers9.GetLength(0); r++) 
        { 
            for (int f = 0; f < numbers9.GetLength(1); f++) 
                { 
                    Console.WriteLine(numbers9[r, f]); 
                } 
        }  

        // more custome methods
        Console.WriteLine();
        int xx = 1;
        int yy = 2;
        SumNumbers(xx, yy);

        Console.WriteLine();
        ReturnString();
        ReturnString("TEST");

        Console.WriteLine();
        Console.WriteLine(ReturnSumNumbers(1,2));

        Console.WriteLine();
        ReturnKids(child1: "Liam", child2: "Liam", child3: "John");

        // custom classes and methods
        Console.WriteLine();
        MyClass myObject = new MyClass();
        Console.WriteLine(myObject.state);

        // custom classes and encapsulation and automatic props
        Console.WriteLine();
        AnotherClass anotherObject = new AnotherClass();
        anotherObject.SecretString = "###";
        Console.WriteLine(anotherObject.SecretString);
        Console.WriteLine();
        anotherObject.SecretString2 = "???";
        Console.WriteLine(anotherObject.SecretString + " " + anotherObject.SecretString2);

        // base class derived class
        Console.WriteLine();
        InheritedClass inheritedObject = new InheritedClass();
        inheritedObject.color = "red";
        inheritedObject.MyMethod();
        Console.WriteLine(inheritedObject.state + " " + inheritedObject.color);

        // overrive base class method
        Console.WriteLine();
        AnotherInheritedClass anotherInheritedObject = new AnotherInheritedClass();
        anotherInheritedObject.MyAnotherInheritedMethod();
        anotherInheritedObject.MyMethod();

        // objects from abstraction
        Console.WriteLine();
        //MyAbstractClass myAbstractObject = new MyAbstractClass(); fails to build
        //myAbstractObject.ShowStatus() cannot be called
        FromAbastractClass myFromAbastractObject = new FromAbastractClass();
        myFromAbastractObject.ShowStatus();
        myFromAbastractObject.DoThing();

        // objects from interfaces
        Console.WriteLine();
        FromInterfaceClass fromInterfaceObject = new FromInterfaceClass();
        fromInterfaceObject.DoSomehing();

        // calling enums
        Console.WriteLine();
        MyEnum myEnumObject = MyEnum.Five;
        Console.WriteLine("Five is " + myEnumObject);
        int myEnumObject2 = (int) MyEnum.Three;
        Console.WriteLine("Three is " + myEnumObject2);

        // switching by enums
        Console.WriteLine();
        MyLevel myVar = MyLevel.Medium;
        switch(myVar) 
        {
            case MyLevel.Low:
            Console.WriteLine("Low level");
            break;
            case MyLevel.Medium:
            Console.WriteLine("Medium level");
            break;
            case MyLevel.High:
            Console.WriteLine("High level");
            break;
        }

        // working with files
        Console.WriteLine();
        string writeText = "This is something to be writted to a file";
        File.WriteAllText("samplefile.txt", writeText);
        string readText = File.ReadAllText("samplefile.txt");
        Console.WriteLine(readText); 
    }

    //custom methodse

    static void TestMethod()
    {
        Console.WriteLine("Executed test method");
    }

    static void SumNumbers(int arg1, int arg2)
    {
        int sum = arg1 + arg2;
        Console.WriteLine("Sum of {0} and {1} is {2}", arg1, arg2, sum);
    }

    static int ReturnSumNumbers(int arg1, int arg2)
    {
        return arg1 + arg2;
    }
    static double ReturnSumNumbers(double arg1, double arg2)
    {
        return arg1 + arg2;
    }

    static void ReturnString(string str = "NOTHING")
    {
        Console.WriteLine("Here is what you provided {0}", str);
    }
    
    static void PrintNumbers()
    {
        int i = 1;

        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    static void PrintEvenNumbers()
    {
        int input = 10;
        int i = 1;

        while (i <= input)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }   

    static void PrintEvenNumbersZero()
    {
        int input = 10;
        int i = 0;

        do
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } 
        while (i <= input);
    }

    static void ReturnKids(string child1, string child2, string child3) 
    {
        Console.WriteLine("The youngest child is: " + child3);
    }
}

// custom classes

class MyClass
{
    public string state = "idle";
    public int time = 0;
    public string? name;
    public string? type;
    public virtual void MyMethod()
    {
        Console.WriteLine("My base action");
    }
}  

sealed class AnotherClass
{
    private string? secret;
    public string SecretString
    {
        get { return secret; }
        set { secret = value; }
    }

    public string? SecretString2
    { get; set; }

    public void AnotherMethod()
    {
        Console.WriteLine(secret);
    }
}

class InheritedClass : MyClass
{
    public string? color;

    public void MyInheritedMethod()
    {
        Console.WriteLine("My \"inherited\" action");
    }
}

class AnotherInheritedClass : MyClass
{
    public string? color;

    public void MyAnotherInheritedMethod()
    {
        Console.WriteLine("My another \"inherited\" action");
    }

    public override void MyMethod()
    {
        Console.WriteLine("My another \"overidden\" action");
    }
}

abstract class MyAbstractClass
{
    public string status = "instantiated";

    public void ShowStatus()
    {
        Console.WriteLine(status);
    }
    public abstract void DoThing();
}

class FromAbastractClass : MyAbstractClass
{
    public override void DoThing()
    {
        Console.WriteLine("Doing my abastract thing");
    }
}

// custom interfaces
interface IInterface 
{
    void DoSomehing();
}

class FromInterfaceClass : IInterface
{
    public void DoSomehing()
    {
        Console.WriteLine("Doing my interface action");
    }
}

// enumeration

enum MyEnum
{
    One,
    Two,
    Three,
    Four,
    Five
}

enum MyLevel 
{
  Low,
  Medium,
  High
}