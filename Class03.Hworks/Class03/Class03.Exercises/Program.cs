
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

#region Exercise 3 

string[] wordsArray = { "apple", "banana", "cherry", "date", "elderberry" };

double[] decimalArray = { 1.12, 2.21, 3.34, 4.67, 5.89 };

char[] characterArray = { 'a', 'b', 'c', 'd', 'e' };

bool[] booleanArray = { true, false, true, false, true, true };

// Array of arrays 

int[][] numbersArray = new int[5][]
{
    new int[] {1, 2},
    new int[] {3, 4},
    new int[] {5, 6},
    new int[] {7, 8},
    new int[] {9, 10}
};

#endregion

#region Exercise 4 

int[] numArray = new int[5];
int sum = 0;

for (int i = 0; i < numArray.Length; i++)
{
    Console.Write("Enter a value for element " + (i + 1) + ": ");
    numArray[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numArray.Length; i++)
{
    sum += numArray[i]; 
}

Console.WriteLine("The sum of all array element is: " + sum);

#endregion

#region Exercise 5

string[] nameArray = new string[100];
int currentIndex = 0;
string userInput;
string continueInput;

do
{
    Console.Write("Enter a name: ");
    userInput = Console.ReadLine();

    if (currentIndex < nameArray.Length)
    {
        nameArray[currentIndex] = userInput;
        currentIndex++;
    }

    else
    {
        Console.WriteLine("Array is full! Cannot add more names.");
        break;
    }

    Console.Write("Do you want to enter another name? (Y/N): ");
    continueInput = Console.ReadLine().ToUpper();

} while (continueInput == "Y");

Console.WriteLine("\nAll names entered: ");

for (int i = 0; i < currentIndex; i++)
{
    Console.WriteLine(nameArray[i]);
}

#endregion