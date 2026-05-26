namespace Class02.Task4.Classes;

public abstract class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }

    protected Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public abstract decimal CalculateSalary();
    public abstract void DisplayInfo(); 
}
