using Class03.Homework.Classes;

namespace Class03.Homework;

public static class UserDatabase
{
    private static List<User> _users = new List<User>()
    {
        new User(1, "Alice", 25),
        new User(2, "Bob", 30),
        new User(3, "Charlie", 25),
        new User(4, "David", 40)
    };

    public static List<User> SearchById(int id)
    {
        return _users.Where(u => u.Id == id).ToList();
    }

    public static List<User> SearchByName(string name)
    {
        return _users.Where(u => u.Name.ToLower() == name.ToLower()).ToList();
    }

    public static List<User> SearchByAge(int age)
    {
        return _users.Where(u => u.Age == age).ToList();
    }
}
