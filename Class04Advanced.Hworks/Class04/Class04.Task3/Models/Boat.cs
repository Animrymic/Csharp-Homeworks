namespace Class04.Task3.Models;
public class Boat : Vehicle
{
    public override void DisplayInfo()
    {
        System.Console.WriteLine("Im a boat and i do not have wheels :(");
    }
}