using Class06.Task3.Models;

Customer[] customers = new Customer[]
{
    new Customer("12345678", 1234, "John", "Doe", 500),
    new Customer("87654321", 4321, "Anna", "Smith", 1000)
};

void Validation()
{
    while (true)
    {
        Customer customer = Authenticate(); 

        if (customer == null)
        {
            Console.WriteLine("Invalid card number or PIN\n");
            continue;
        }
        Console.WriteLine($"\nWelcome {customer.Fullname()}!\n");

        RunATM(customer); 
    }
}

    // Start the ATM validation loop
    Validation();
Customer Authenticate()
{
    Console.Write("Enter card number: ");
    string cardNumber = Console.ReadLine();

    Console.Write("Enter PIN: ");
    int.TryParse(Console.ReadLine(), out int pin);

    foreach (Customer c in customers)
    {
        if (c.CardNumber == cardNumber && c.ValidatePin(pin))
            return c;
        
    }
    return null;
}

void RunATM(Customer customer)
{
    while (true)
    {
        int choice = ShowMenu();

        switch (choice)
        {
            case 1:
                CheckBalance(customer);
                break;
            case 2:
                Withdraw(customer);
                break;
            case 3:
                Deposit(customer);
                break;
            case 4:
                RegisterCustomer();
                break;
            case 5:
                return;
            default:
                Console.WriteLine("Invalid option!\n");
                break;
        }

        Console.WriteLine("\nDo you want another action? (Y/N)");
        string again = Console.ReadLine().ToUpper();

        if (again != "Y")
            Environment.Exit(0); // AI helped regarding this :)
    }
}
int ShowMenu()
{
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Withdraw Cash");
    Console.WriteLine("3. Deposit Cash");
    Console.WriteLine("4. Register New Card");
    Console.WriteLine("5. Exit");
    Console.Write("Choose option: ");

    int.TryParse(Console.ReadLine(), out int choice);
    return choice;
}

void CheckBalance(Customer customer)
{
    Console.WriteLine($"Your balance is: {customer.GetBalance()}");
}

void Withdraw(Customer customer)
{
    Console.Write("Enter amount: ");
    int.TryParse(Console.ReadLine(), out int amount);

    if (customer.WithdrawCash(amount))
        Console.WriteLine("Withdrawal successful.");
    else
        Console.WriteLine("Insufficient funds.");
}
void Deposit(Customer customer)
{
    Console.Write("Enter amount: ");
    int.TryParse(Console.ReadLine(), out int amount);

    customer.DepositCash(amount);
    Console.WriteLine("Deposit successful.");
}

void RegisterCustomer()
{
    Console.Write("Enter card number: ");
    string cardNumber = Console.ReadLine();

    foreach (Customer c in customers)
    {
        if (c.CardNumber == cardNumber)
        {
            Console.WriteLine("Card already exists!\n");
            return;
        }
    }

    Console.Write("Enter PIN: ");
    int.TryParse(Console.ReadLine(), out int pin);

    Console.Write("Enter first name: ");
    string firstName = Console.ReadLine();

    Console.Write("Enter last name: ");
    string lastName = Console.ReadLine();

    Customer newCustomer = new Customer(cardNumber, pin, firstName, lastName, 0);

    Array.Resize(ref customers, customers.Length + 1);
    customers[customers.Length - 1] = newCustomer;

    Console.WriteLine("Registration successful!\n");
}


