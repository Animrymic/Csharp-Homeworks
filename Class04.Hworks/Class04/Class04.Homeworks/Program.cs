


static void Main()
{
    Console.Write("Enter your birthdate (yyyy-mm-dd): ");
    DateTime birthDate = DateTime.Parse(Console.ReadLine());

    int age = AgeCalculator(birthDate);

    Console.WriteLine("Your age is: " + age);

    // Keeps console open
    Console.ReadLine();
}

static int AgeCalculator(DateTime birthDate)
{
    DateTime today = DateTime.Today;

    int age = today.Year - birthDate.Year;

    if (today.Month < birthDate.Month ||
       (today.Month == birthDate.Month && today.Day < birthDate.Day))
    {
        age--;
    }

    return age;
}