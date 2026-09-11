using System;

class Que_2
{
    delegate float Calculator(float a, float b);

    static float Add(float a, float b)
    {
        Console.WriteLine(a + b);
        return a + b;
    }

    public static void Main(string[] args)
    {
        float num1 = Convert.ToSingle(Console.ReadLine());
        float num2 = Convert.ToSingle(Console.ReadLine());

        Calculator del = new Calculator(Add);

        del(num1, num2);
    }
}
