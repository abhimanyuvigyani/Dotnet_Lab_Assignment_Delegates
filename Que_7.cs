using System;

class Que_7
{
   
    delegate void MyDelegate();

 
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
       
        MyDelegate del = Method1;
        del += Method2;
        del += Method3;

       
        Delegate[] methods = del.GetInvocationList();

        Console.WriteLine("Methods stored in the delegate:");

       
        foreach (Delegate d in methods)
        {
            Console.WriteLine("Method Name: " + d.Method.Name);

            
            d.DynamicInvoke();

            Console.WriteLine();
        }
    }
}
