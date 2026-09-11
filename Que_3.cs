using System;

class Que_3
{
    delegate void Sir_ye_3rd_assignment_hai_ya_4th();

    static void Method1()
    {
        Console.WriteLine("Ye hai pahla pahla method 🎵");
    }

    static void Method2()
    {
        Console.WriteLine("ye hai method 2 obviously");
    }

    public static void Main()
    {
        Sir_ye_3rd_assignment_hai_ya_4th d1 = Method1;

        Console.WriteLine("Unicast Delegate:");
        d1();

        Sir_ye_3rd_assignment_hai_ya_4th d2 = Method1;
        d2 += Method2;

        Console.WriteLine("\nMulticast Delegate:");
        d2();
    }
}
