﻿namespace console_fundamentals_again;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //string props and methods
        Console.WriteLine();
        string myString = "Hello ";
        Console.WriteLine("/" + myString + "/");
        Console.WriteLine(myString[1]);  // Outputs "e"
        Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
        Console.WriteLine(myString.Length);
        Console.WriteLine("/" + myString.TrimEnd(' ') + "/");
        
        //more string methods
        Console.WriteLine();
        string nameTest = "John Doe";
        Console.WriteLine(nameTest);
        int charPos = nameTest.IndexOf("D");
        string lastName = nameTest.Substring(charPos);
        Console.WriteLine(lastName);
        
        //if condition
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

        //if else condition
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

        //ternary condition
        Console.WriteLine();
        DateTime time2 = DateTime.Now;
        string greeting2 = (time2.Hour < 11) ? "morning" : "hey";
        Console.WriteLine(greeting2);

        //switch cases
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

        //custom method
        Console.WriteLine();
        PrintEvenNumbers();

        //i'm here
        Console.WriteLine();


    }

        //custom method
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
}
