using Class04.Homework.Extensions;
using Class04.Homework.Models;

int number = 10;
string text = "Hello World";
double pi = 3.14;

number.Print();
text.Print();
pi.Print();

Console.WriteLine("--------------------");

List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.PrintCollection();

Console.WriteLine("--------------------");

string[] names = new string[] { "Alice", "Bob", "Charlie" };
names.PrintCollection();

Console.WriteLine("--------------------");

List<User> users = new List<User>();
users.Add(new User(1, "Alice"));
users.Add(new User(2, "Bob"));

users.PrintCollection();