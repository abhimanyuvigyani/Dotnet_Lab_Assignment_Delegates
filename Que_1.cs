using System;
class Program
{
    delegate void Placement_chahiye_sir_please(string message);

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    static void Main1(string[] args)
    {
        MyDelegate del = new MyDelegate(ShowMessage);
        del(".NET classes are interesting if I Talk about attendance!");
    }
}
