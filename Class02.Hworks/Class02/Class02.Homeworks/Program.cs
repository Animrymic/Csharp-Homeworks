#region Exercise 1

//DOUBLE VARIABLES
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