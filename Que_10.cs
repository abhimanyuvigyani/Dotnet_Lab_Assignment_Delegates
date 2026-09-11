// What is the built-in Predicate delegate?

// Predicate<T> is a built-in generic delegate in C# provided by the System namespace.

// It is used to check a condition on a value.

// It:

// accepts one input parameter
// returns a bool value
// true means the condition is satisfied
// false means the condition is not satisfied



//Syntax:
// Predicate<T> name;

// For integers:
// Predicate<int> check;                 //This means check can store a method that takes an int and returns bool.

// For example:
// static bool IsEven(int number)
// {
//     return number % 2 == 0;
// }

// can be stored in:
// Predicate<int> check = IsEven;




using System;

class Program
{
    
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }


    static bool IsPositive(int number)
    {
        return number > 0;
    }

    static bool IsGreaterThan100(int number)
    {
        return number > 100;
    }

    static void Main()
    {
        int number = 120;

        
        Predicate<int> check = IsEven;

        check += IsPositive;
        check += IsGreaterThan100;

      
        Delegate[] methods = check.GetInvocationList();

        Console.WriteLine("Checking number: " + number);
        Console.WriteLine();

      
        foreach (Delegate d in methods)
        {
            bool result = (bool)d.DynamicInvoke(number);

            Console.WriteLine(
                "Method Name: " + d.Method.Name +
                ", Result: " + result
            );
        }
    }
}
