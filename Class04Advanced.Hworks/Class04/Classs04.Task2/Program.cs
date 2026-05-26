using Classs04.Task2.Extensions;
using Classs04.Task2.Models;
using Classs04.Task2.Modelsl;

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DIsplayInfo();
motorBike.DIsplayInfo();
boat.DIsplayInfo();
plane.DIsplayInfo();

Console.WriteLine("--------------------");

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car());
vehicles.Add(new MotorBike());
vehicles.Add(new Boat());
vehicles.Add(new Airplane());

vehicles.PrintAll();