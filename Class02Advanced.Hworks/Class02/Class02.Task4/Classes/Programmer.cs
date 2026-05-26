namespace Class02.Task4.Classes;

public class Programmer : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Programmer(string name, int id, decimal hourlyRate, int hoursWorked) 
        :base(name, id)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;

    }
    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Role: Programmer");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Salary: {CalculateSalary()}");
        Console.WriteLine("----------------------");
    }
}
