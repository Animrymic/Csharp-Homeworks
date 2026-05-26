using Class02.Task2_3.Interfaces;

namespace Class02.Task2_3.Classes;

public class Triangle : Shape, IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }
    public override double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    public double GetArea()
    {
        throw new NotImplementedException();
    }
}
