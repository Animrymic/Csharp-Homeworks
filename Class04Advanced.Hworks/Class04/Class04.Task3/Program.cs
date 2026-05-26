using Class04.Task3.Extensions;
using Class04.Task3.Models;

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

Console.WriteLine("--------------------");

Car c = new Car();
MotorBike m = new MotorBike();
Boat b = new Boat();
Airplane p = new Airplane();

c.Drive();
m.Wheelie();
b.Sail();
p.Fly();