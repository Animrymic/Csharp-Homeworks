RunApp();
static void NumberStats(double number)
{
    Console.WriteLine($"\nStats for this number: {number} ");

    if(number > 0)
    {
        Console.WriteLine("Positive");
    } else if (number < 0)
    {
        Console.WriteLine("Negative");
    } else
    {
        Console.WriteLine("Zero");
    }

    if (number % 1 == 0)
        Console.WriteLine("Integer");
    else
        Console.WriteLine("Decimal");

    if (number % 1 == 0)
    {
        if ((int)number % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
    else
    {
        Console.WriteLine("Neither odd nor even (decimal number)");
    }
}

static void RunApp()
{
    while (true)
    {
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();

        if (!double.TryParse(input, out double number))
        {
            Console.WriteLine("Invalid input! Please enter a valid number!");
            continue;
        }

        NumberStats(number);

        Console.WriteLine("\nPress Y to try again or X to exit!");
        string choice = Console.ReadLine().ToUpper();

        if (choice == "X")
        {
            break;
        }
        else if (choice != "Y")
        {
            Console.WriteLine("Invalid choice!");
        }
    }

}


