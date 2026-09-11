//What is the built-in Func delegate?

//Func is a built-in generic delegate in C# provided by the System namespace.

//It is used when a method:

//accepts zero or more input parameters
//returns a value

//The last generic type in Func represents the return type.

//Examples:
//Func<int, int> f;
//means:
//Takes an int → returns an int

//Func<int, int, int> f;
//means:
//Takes two int values → returns an int

//So:
//Func<int, int, int>
//can represent a method like:
// static int Add(int a, int b)
// {
//     return a + b;
// }


using System;

class Program
{
   
    static int Add(int a, int b)
    {
        return a + b;
    }

    
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        
        Func<int, int, int> operation = Add;

        Console.WriteLine("Unicast Func:");
        int result = operation(10, 5);

        Console.WriteLine("Result of Add: " + result);


        
        Func<int, int, int> operations = Add;

        operations += Subtract;
        operations += Multiply;

        Console.WriteLine("\nMulticast Func:");

      
        Delegate[] methods = operations.GetInvocationList();

       
        foreach (Delegate d in methods)
        {
            int returnedValue = (int)d.DynamicInvoke(10, 5);

            Console.WriteLine(
                "Method Name: " + d.Method.Name +
                ", Returned Value: " + returnedValue
            );
        }
    }
}
