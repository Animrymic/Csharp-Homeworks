namespace ClassLibrary.CompanyApp;

public enum Role
{
    Sales,
    Manager,
    Other
}

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Role Role { get; set; }

    protected double Salary;

    public Employee(string firstName, string lastName, Role role, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Role = role;
        Salary = salary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Role: {Role}");
    }

    public virtual double GetSalary()
    {
        return Salary;
    }
}
