using System.Diagnostics.Contracts;

namespace Classs04.Task2.Models;

public class MotorBike : Vehicle
{
    public override void DIsplayInfo()
    {    
        Console.WriteLine($"I am a motorbike and I have 2 wheels!");
    }
}
