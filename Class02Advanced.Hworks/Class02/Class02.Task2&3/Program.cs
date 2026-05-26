using Class02.Task2_3.Classes;
using Class02.Task2_3.Interfaces;

//IShape[] shapes = new IShape[]
//{
//            new Rectangle(10, 5),
//            new Circle(7),
//            new Triangle(6, 4)
//};

//foreach (IShape shape in shapes)
//{
//    Console.WriteLine("Area: " + shape.GetArea());
//}

Shape rectangle = new Rectangle(10, 5);
Shape circle = new Circle(7);
Shape triangle = new Triangle(3, 4, 5);

rectangle.DisplayInfo();
circle.DisplayInfo();
triangle.DisplayInfo();