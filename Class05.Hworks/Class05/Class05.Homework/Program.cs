using Class05.Homework.Modules;
#region Exercise 1
   
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        // Create object
        Human person = new Human();
        person.FirstName = firstName;
        person.LastName = lastName;
        person.Age = age;

        // Print result
        Console.WriteLine("\nPerson Info:");
        Console.WriteLine(person.GetPersonStats());

        Console.ReadKey();

#endregion

#region Exercise 2

    // Ask for dog data
    Console.Write("Enter dog name: ");
    string name = Console.ReadLine();

    Console.Write("Enter dog race: ");
    string race = Console.ReadLine();

    Console.Write("Enter dog color: ");
    string color = Console.ReadLine();

    // Create object
    Dog dog = new Dog();
    dog.Name = name;
    dog.Race = race;
    dog.Color = color;

    // Ask for action
    Console.WriteLine("\nChoose an action:");
    Console.WriteLine("1. Eat");
    Console.WriteLine("2. Play");
    Console.WriteLine("3. Chase Tail");

    Console.Write("Enter choice (1-3): ");
    int choice = int.Parse(Console.ReadLine());

    // Call selected method
    switch (choice)
    {
        case 1:
            dog.Eat();
            break;
        case 2:
            dog.Play();
            break;
        case 3:
            dog.ChaseTail();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

    Console.ReadKey();


#endregion

#region Exercise 3
   
        // Create array with 5 students
        Student[] students = new Student[5];

        students[0] = new Student { Name = "Ana", Academy = "IT", Group = "G1" };
        students[1] = new Student { Name = "Marko", Academy = "Design", Group = "G2" };
        students[2] = new Student { Name = "Elena", Academy = "IT", Group = "G3" };
        students[3] = new Student { Name = "Stefan", Academy = "Business", Group = "G1" };
        students[4] = new Student { Name = "Ivana", Academy = "IT", Group = "G2" };

        // Ask user for name
        Console.Write("Enter student name: ");
        string inputName = Console.ReadLine();

        bool found = false;

        // Search for student
        foreach (Student s in students)
        {
            if (s.Name.Equals(inputName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nStudent found:");
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("Academy: " + s.Academy);
                Console.WriteLine("Group: " + s.Group);
                found = true;
                break;
            }
        }

        // If not found
        if (!found)
        {
            Console.WriteLine("Error: Student not found.");
        }

Console.ReadKey(); 

#endregion