using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        
        var employees = new List<IEmployee>
        {
            new Manager { BaseSalary = 50000, Bonus = 10000 },
            new Developer { BaseSalary = 40000, Bonus = 5000 },
            new Intern { Stipend = 2000 }
        };

        var salaryCalculator = new SalaryCalculator();
        salaryCalculator.PrintSalary(employees);
        
    }
}
class SalaryCalculator
{
    public void PrintSalary(List<IEmployee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"Salary: {employee.CalculateSalary()}");
        }
    }
      
}
public interface IEmployee
{
    public double CalculateSalary();
}

class Manager : IEmployee
{
    public decimal BaseSalary {get; set;}
    public decimal Bonus {get; set;}

    public double CalculateSalary()
    {
        return (double)(BaseSalary + Bonus);
    }
} 

class Developer : IEmployee
{
    public decimal BaseSalary {get; set;}
    public decimal Bonus {get; set;}
    public double CalculateSalary()
    {
        return (double)(BaseSalary + Bonus);
    }
}

class Intern : IEmployee
{
    
    public decimal Stipend {get; set;}
    public double CalculateSalary()
    {
        return (double)Stipend;
    }
}
