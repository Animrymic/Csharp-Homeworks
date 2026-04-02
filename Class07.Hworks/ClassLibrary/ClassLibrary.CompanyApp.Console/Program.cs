using ClassLibrary.CompanyApp;

var manager = new Manager("Alice", "Smith", 3000);
manager.AddBonus(500);
manager.PrintInfo();
Console.WriteLine($"Salary: {manager.GetSalary()}");

var sales = new SalesPerson("Bob", "Jones");
sales.AddSuccessRevenue(6000);
sales.PrintInfo();
Console.WriteLine($"Salary: {sales.GetSalary()}");

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
