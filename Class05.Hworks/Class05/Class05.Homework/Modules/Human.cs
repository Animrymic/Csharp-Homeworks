namespace Class05.Homework.Modules
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonStats()
        {
            return "Full Name: " + FirstName + " " + LastName + "\nAge: " + Age;
        }
    }
}
