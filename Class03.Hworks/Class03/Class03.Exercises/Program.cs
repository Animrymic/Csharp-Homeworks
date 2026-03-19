
#region Exercise 1

// Count up to 

Console.WriteLine("Enter a number to count up to: ");
int countUpNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Numbers from 1 to: " + countUpNumber + ":");

for (int i = 1; i <= countUpNumber; i++)
{
    Console.Write(i + " "); 
}

Console.WriteLine();

// Count down to 

Console.WriteLine("Enter a number to count down to: ");
int countDownNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Number from " + countDownNumber + " down to 1:");

for(int i = countDownNumber; i >= 1; i--)
{
    Console.Write(i + " ");
}

Console.WriteLine();

// Print all even numbers from 2 up to user input

Console.WriteLine("Enter a number to print even number up to: ");
int evenUpToNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Even numbers from 2 up to " + evenUpToNumber + ":");

for (int i = 2; i <= evenUpToNumber; i += 2)
{
    Console.Write(i + " "); 
}

Console.WriteLine();

// Print all odd numbers from 1 to user input

Console.WriteLine("Enter a number to print odd numbers up to: ");
int oddUpToNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Odd numbers from 1 up to " + oddUpToNumber + ":");

for (int i = 1; i <= oddUpToNumber; i += 2)
{
    Console.Write(i + " "); 
}
Console.WriteLine();

#endregion

#region Exercise 2

Console.Write("Enter a number: ");
int userNumber = int.Parse(Console.ReadLine()); 

for (int i = 1; i <= userNumber; i++)
{

    if (i > 100)
    {
        Console.WriteLine("The limit is reached!");
        break;
    }

    if (i % 3 == 0 || i % 7 == 0)
    {
        continue;
    }

    Console.WriteLine(i);
}

#endregion