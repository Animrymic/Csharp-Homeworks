using Class04.Task3.Models;

namespace Class04.Task3.Extensions;

public static class VehicleActions
{
    public static void Drive(this Car car)
    {
        Console.WriteLine("Driving the car...");
    }

    public static void Wheelie(this MotorBike motorBike)
    {
        Console.WriteLine("Doing a wheelie on the motorbike...");
    }

    public static void Sail(this Boat boat)
    {
        Console.WriteLine("Sailing the boat...");
    }

    public static void Fly(this Airplane airplane)
    {
        Console.WriteLine("Flying the airplane...");
    }
}
