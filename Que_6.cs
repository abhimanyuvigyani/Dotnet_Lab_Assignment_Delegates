
using System;

class Salary_Calculator
{
    
    delegate double SalaryPart(double basicSalary);

    static double CalculateBasic(double basicSalary)
    {
        return basicSalary;
    }

    static double CalculateHRA(double basicSalary)
    {
        return basicSalary * 0.20;
    }

    static double CalculateDA(double basicSalary)
    {
        return basicSalary * 0.10;
    }

    static double CalculateBonus(double basicSalary)
    {
        return basicSalary * 0.15;
    }

    public static void Main()
    {
        double basicSalary = 30000;

        
        SalaryPart salaryDetails = CalculateBasic;

        salaryDetails += CalculateHRA;
        salaryDetails += CalculateDA;
        salaryDetails += CalculateBonus;

        Console.WriteLine("Basic Salary: " + basicSalary);
        Console.WriteLine("\nSalary Components:");

        
        Delegate[] salaryMethods = salaryDetails.GetInvocationList();

        foreach (SalaryPart method in salaryMethods)
        {
            double amount = method(basicSalary);

            Console.WriteLine(method.Method.Name + " = " + amount);
        }
    }
}
