//What is the built-in Action delegate?

//Action is a built-in generic delegate in C# provided by the System namespace.

//It is used when you want a delegate that:

//takes zero or more parameters
//returns nothing (void)

//for example:
//Action<int> a;

//a can store a method that takes one int parameter and returns void.

//Basic syntax:
//Action<parameter-types> delegateName;

//Examples:
//Action a;                 // No parameter
//Action<int> a;            // One int parameter
//Action<int, int> a;       // Two int parameters


//Unlike a custom delegate, you don't need to declare:
//delegate void MyDelegate(int x);
//because Action<int> already provides that delegate type.


using System;

class Que_8
{
    
    static void Method1()
    {
        Console.WriteLine("Method 1 is called");
    }

    static void Method2()
    {
        Console.WriteLine("Method 2 is called");
    }

    static void Method3()
    {
        Console.WriteLine("Method 3 is called");
    }

    static void Main()
    {
        
        Action action1 = Method1;

        Console.WriteLine("Unicast Action:");
        action1();


        
        Action action2 = Method1;
        action2 += Method2;
        action2 += Method3;

        Console.WriteLine("\nMulticast Action:");
        action2();
    }
}


