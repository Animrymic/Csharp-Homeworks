namespace Class02.Task2_3.Classes;

public abstract class Shape
{
    public abstract double CalculateArea(); 
    public abstract double CalculatePerimeter();

    public void DisplayInfo()
    {
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Perimeter: " + CalculatePerimeter());
        Console.WriteLine("----------------------");
    }
}
