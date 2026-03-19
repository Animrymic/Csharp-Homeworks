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



#endregion