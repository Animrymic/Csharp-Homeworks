using Class06.Task2.Models;

 User[] users = new User[]
{
    new User { Id = 23, Username = "user23", Password = "12345", Messages = new string[] { "Message1", "Message2" } },
    new User { Id = 44, Username = "user44", Password = "abcde", Messages = new string[] { "Hello", "Welcome" } },
    new User { Id = 1, Username = "user1", Password = "password", Messages = new string[] { "Test message" } }
};

void ChoiceValidation()
{
    while(true)
    {
        int choice = ShowMenu();

        switch (choice)
        {
            case 1:
                Login();
                break;
            case 2:
                Register();
                break;
            case 3:
                return;
            default:
                Console.WriteLine("Invalid choice!\n");
                break;
        }
    }
}

int ShowMenu()
{
    Console.Write("Please choose an option: ");
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Register");
    Console.WriteLine("3. Exit");

    int.TryParse(Console.ReadLine(), out int choice);
    return choice;
}

void Login()
{
    Console.Write("Username: ");
    string username = Console.ReadLine();

    Console.Write("Password: ");
    string password = Console.ReadLine();

    User user = FindUser(username, password);

        if (user == null)
    {
        Console.WriteLine("Error, user not found!\n");
        return;
    }
    Console.WriteLine($"Welcome {user.Username}. Here are your unread messages: ");
    foreach (var message in user.Messages)
    {
        Console.WriteLine(message);      
    }
    Console.WriteLine();
}

void Register()
{
    Console.Write("Enter ID: ");
    int.TryParse(Console.ReadLine(), out int id);

    Console.Write("Enter Username: ");
    string username = Console.ReadLine();

    foreach (User u in users)
    {
        if( u.Username == username)
        {
            Console.WriteLine("User with that username already exists!");
            return;
        }        
    }

    Console.Write("Enter Password: ");
    string password = Console.ReadLine();

    User newUser = new User
    {
        Id = id,
        Username = username,
        Password = password,
        Messages = new string[] { }
    };

    Array.Resize(ref users, users.Length + 1);
    users[users.Length - 1] = newUser;

    PrintUsers();
}

void PrintUsers()
{
    Console.WriteLine("\nRegistration complete! Users:");
    foreach (User user in users)
    {
        Console.WriteLine($"{user.Id} {user.Username}");
    }
    Console.WriteLine();
}

User FindUser(string username, string password)
{
    foreach (User user in users)
    {
        if (user.Username == username && user.Password == password)
            return user;
    }
    return null;
}

ChoiceValidation();
