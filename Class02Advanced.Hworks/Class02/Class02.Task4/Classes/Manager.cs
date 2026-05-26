namespace Class02.Task4.Classes;

public class Manager : Employee
{

    public decimal BaseSalary { get; set; }
    public decimal Bonus { get; set; }

    public Manager(string name, int id, decimal baseSalary, decimal bonus) 
        : base(name,id)
    {
        BaseSalary = baseSalary;
        Bonus = bonus;
    }
    public override decimal CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Role: Manager");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Salary: {CalculateSalary()}");
        Console.WriteLine("----------------------");
    }
}
