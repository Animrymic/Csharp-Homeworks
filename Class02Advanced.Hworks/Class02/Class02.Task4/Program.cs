using Class02.Task4.Classes;

Employee[] employees = new Employee[]
{
    new Manager("Alice", 1, 5000m, 1200m),
    new Programmer("Bob", 2, 25m, 160)
};

foreach (Employee emp in employees)
{
    emp.DisplayInfo();
}