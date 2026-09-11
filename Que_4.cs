using System;

class Que_4
{
    delegate int Haan_haan_ye_Calculator_delegate_hi_hai(int a, int b);
    static int Addition_ke_liye_ye_method_hain(int a, int b)
    {
        return a + b;
    }
    static int Subtraction_ke_liye_ye_method_hai(int a, int b)
    {
        return a - b;
    }
    static int Multiplication_ke_liye_ye_method_hai(int a, int b)
    {
        return a * b;
    }
    static int Division_ke_liye_ye_method_hai(int a, int b)
    {
        return a / b;
    }
    public static void Main(string[] args)
    {
        Console.Write("a ki value type karo yawr: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b ki value type karo yawr: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Haan_haan_ye_Calculator_delegate_hi_hai Del_jo_variable_name_hai_delegate_ka;
        Del_jo_variable_name_hai_delegate_ka = Addition_ke_liye_ye_method_hain;
        Console.WriteLine("Addition = " + Del_jo_variable_name_hai_delegate_ka(a, b));
        Del_jo_variable_name_hai_delegate_ka = Subtraction_ke_liye_ye_method_hai;
        Console.WriteLine("Subtraction = " + Del_jo_variable_name_hai_delegate_ka(a, b));
        Del_jo_variable_name_hai_delegate_ka = Multiplication_ke_liye_ye_method_hai;
        Console.WriteLine("Multiplication = " + Del_jo_variable_name_hai_delegate_ka(a, b));
        Del_jo_variable_name_hai_delegate_ka = Division_ke_liye_ye_method_hai;
        Console.WriteLine("Division = " + Del_jo_variable_name_hai_delegate_ka(a, b));
    }
}
