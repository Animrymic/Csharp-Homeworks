using Class03.Homework;
using Class03.Homework.Classes;

Console.WriteLine("Search by Id = 2");
var byId = UserDatabase.SearchById(2);
PrintUsers(byId);

Console.WriteLine("\nSearch by Name = Alice");
var byName = UserDatabase.SearchByName("Alice");
PrintUsers(byName);

Console.WriteLine("\nSearch by Age = 25");
var byAge = UserDatabase.SearchByAge(25);
PrintUsers(byAge);
    
static void PrintUsers(List<User> users)
{
    foreach (var user in users)
    {
        Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
    }
}
