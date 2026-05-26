using Class06.Homework.Models;
using System.Text.RegularExpressions;

//Filter all cars that have origin from Europe.
List<Car> europeCars = CarsData.Cars
    .Where(o => o.Origin == "Europe")
    .ToList();

//Find all unique cylinder values for cars.
List<int> uniqueCylinders = CarsData.Cars
    .Select(c => c.Cylinders)
    .Distinct()
    .ToList();

//Select all car names with their model names converted to uppercase.
List<string> upperCaseModel = CarsData.Cars 
    .Select(c => c.Model.ToUpper())
    .ToList();

//Check if there are any cars with horsepower greater than 300.
bool hasOver300HP = CarsData.Cars 
    .Any(c => c.HorsePower > 300);

//Find the car with the highest horsepower.
Car maxHPcar = CarsData.Cars
    .OrderByDescending(c => c.HorsePower)
    .First();

//Filter all "Chevrolet" cars and order them by weight in descending order.
List<Car> chevroletCars = CarsData.Cars
    .Where(c => c.Model.Contains("Chevrolet"))
    .OrderByDescending(c => c.Weight)
    .ToList();

//Find the car with the longest model name.
Car longestModelName = CarsData.Cars
    .OrderByDescending(c => c.Model.Length)
    .First();

//Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.
var groupedByOrigin = CarsData.Cars
    .GroupBy(c => c.Origin)
    .OrderBy(g => g.Count())
    .ToList();

//Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())
List<Car> topFiveHorsePower = CarsData.Cars
    .OrderByDescending(c => c.HorsePower)
    .Take(5)
    .ToList();

//Find the car with the highest acceleration time.
Car slowestAcceleration = CarsData.Cars
    .OrderByDescending(c => c.AccelerationTime)
    .First();

//Select only the model and horsepower of cars with horsepower greater than 200.
var fastCars = CarsData.Cars
    .Where(c => c.HorsePower > 200)
    .Select(c => new { c.Model, c.HorsePower })
    .ToList();

//Select all unique origins of cars, ordered alphabetically (ascending).
List<string> origins = CarsData.Cars
    .Select(c => c.Origin)
    .Distinct()
    .OrderBy(o => o)
    .ToList();

//Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.
List<Car> carsMoreThan4Cylinders = CarsData.Cars
    .Where(c => c.Cylinders > 4)
    .OrderBy(c => c.Origin)
    .ThenByDescending(c => c.HorsePower)
    .ToList();

//Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.
List<Car> combined= CarsData.Cars
    .Where(c => c.Cylinders > 6 || (c.Cylinders == 4 && c.HorsePower > 110))
    .ToList();

//Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.
List<Car> powerfulCars = CarsData.Cars
    .Where(c => c.HorsePower > 200)
    .ToList();
double minMpg = powerfulCars.Min(c => c.MilesPerGalon);
double maxMpg = powerfulCars.Max(c => c.MilesPerGalon);
double avgMpg = powerfulCars.Average(c => c.MilesPerGalon);

//Custom requirement 1 - Cars heavier than 1500, sorted by HP, show uppercase model
List<string> custom1 = CarsData.Cars
    .Where(c => c.Weight > 1500)
    .OrderByDescending(c => c.HorsePower)
    .Select(c => c.Model.ToUpper())
    .ToList();

//Custom requirement 2 - USA cars, ordered by acceleration, then HP
List<Car> custom2 = CarsData.Cars
    .Where(c => c.Origin == "US")
    .OrderBy(c => c.AccelerationTime)
    .ThenByDescending(c => c.HorsePower)
    .ToList();
 