using System.Security.Cryptography.X509Certificates;

namespace Class06.Task2.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string[] Messages { get; set; }
}
