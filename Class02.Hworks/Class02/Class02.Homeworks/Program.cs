#region Exercise 1

//DOUBLE VARIABLES
using System.Security.Principal;

double doubleNum1 = 9;
double doubleNum2 = 3;
double doubleResult = doubleNum1 / doubleNum2;

Console.WriteLine("Double division result: " + doubleResult);

// INT VARIABLES
int intNum1 = 9;
int intNum2 = 3;
int intResult = intNum1 / intNum2;

Console.WriteLine("Int division result: " + intResult);

// COMPARISON
Console.WriteLine("Are results equal? " + (doubleResult == intResult));

// STRING CONCATENATION
string firstText = "Hello ";
string secondText = "World";
string combinedText = firstText + secondText;

Console.WriteLine("Concatenated string: " + combinedText);

// STRING NUMBERS CONCATENATION
string stringNine = "9";
string stringThree = "3";
string concatenatedNumbers = stringNine + stringThree;

Console.WriteLine("Concatenated numbers as string: " + concatenatedNumbers);


#endregion

#region Exercise 2

int numberValue = 7;
string textValue = "The number is: ";

string resultText = textValue + numberValue;

Console.WriteLine(resultText);

#endregion

#region Exercise 3

int creditAmount = 102;
int smsCount = 5;

int numberOfMessages = creditAmount / smsCount;

Console.WriteLine("You can send " + numberOfMessages + " SMS messages.");

#endregion

#region Exercise 4

int applesPerBranch = 8;
int branchesPerTree = 12;
int basketCapacity = 5;

Console.Write("Enter a number of trees: ");
int numberOfTrees = int.Parse(Console.ReadLine());

int totalApples = numberOfTrees * branchesPerTree * applesPerBranch;

int basketsNeeded = totalApples / basketCapacity;

if (totalApples % basketCapacity != 0)
{
    basketsNeeded++;
}

Console.WriteLine("Total apples: " + totalApples);
Console.WriteLine("Total baskets: " + basketsNeeded);

#endregion

#region Exercise 5

int firstNumberValue = 12;
int secondNumberValue = 7;

int largeNumberValue; 

if(firstNumberValue > secondNumberValue)
{
    largeNumberValue = firstNumberValue; 
}
else
{
    largeNumberValue = secondNumberValue; 
}

if(largeNumberValue % 2 == 0)
{
    Console.WriteLine("The larger number from the two is: " + largeNumberValue);
    Console.WriteLine("And the number is even");
}
else
{
    Console.WriteLine("The larger number from the two is: " + largeNumberValue);
    Console.WriteLine("And the number is odd");
}
#endregion

#region Exercise 6

Console.Write("Enter a number from 1 to 3: ");
int userChoiceNumber = int.Parse(Console.ReadLine()); 

if (userChoiceNumber == 1)
{
    Console.WriteLine("You got a new car!");
}
else if (userChoiceNumber == 2)
{
    Console.WriteLine("You got a new plane!");
}
else if (userChoiceNumber == 3)
{
    Console.WriteLine("You got a new bike!");
}
else
{
    Console.WriteLine("Error: Invalid input");
}

#endregion

#region Task 1 Homework.md 


// Ask for the first number
Console.Write("Enter the first number: ");
string firstInput = Console.ReadLine();
double firstNumber;
while (!double.TryParse(firstInput, out firstNumber))
{
    Console.Write("Invalid input! Enter a valid number: ");
    firstInput = Console.ReadLine();
}

// Ask for the second number
Console.Write("Enter the second number: ");
string secondInput = Console.ReadLine();
double secondNumber;
while (!double.TryParse(secondInput, out secondNumber))
{
    Console.Write("Invalid input! Enter a valid number: ");
    secondInput = Console.ReadLine();
}

// Ask for the operation
Console.Write("Enter the operation (+, -, *, /): ");
string operation = Console.ReadLine();

double result = 0;
bool validOperation = true;

// Perform calculation
switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    case "*":
        result = firstNumber * secondNumber;
        break;
    case "/":
        if (secondNumber != 0)
            result = firstNumber / secondNumber;
        else
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            validOperation = false;
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operation!");
        validOperation = false;
        break;
}

if (validOperation)
{
    Console.WriteLine("The result is: " + result);
}

#endregion

#region Task 2 Homework.md

Console.Write("Enter the first number: ");
double firstNumValue = double.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
double secondNumValue = double.Parse(Console.ReadLine());

Console.Write("Enter the third number: ");
double thirdNumValue = double.Parse(Console.ReadLine());

Console.Write("Enter the fourth number: ");
double fourthNumValue = double.Parse(Console.ReadLine());

double averageValue = (firstNumValue + secondNumValue + thirdNumValue + fourthNumValue) / 4;

Console.WriteLine($"The average of {firstValue}, {secondValue}, {thirdValue} and {fourthValue} is: {averageValue}");

#endregion

#region Task 3 Homework.md

Console.Write("Input the first number: ");
int firstValSum = int.Parse(Console.ReadLine());

Console.Write("Input the second number: ");
int secondValSum = int.Parse(Console.ReadLine());

int tempValue = firstValSum;
firstValSum = secondValSum;
secondValSum = tempValue;

Console.WriteLine("\nAfter Swapping:");
Console.WriteLine("First Number: " + firstValSum);
Console.WriteLine("Second Number: " + secondValSum);

#endregion