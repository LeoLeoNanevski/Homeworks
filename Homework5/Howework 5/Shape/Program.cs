
using Shape;

static void Main(string[] args)
{
    // create a new rectangle
    Rectangle rectangle = new Rectangle("Rectangle", "blue", new int[] { 0, 0 }, 5, 10);
    rectangle.PrintInfo();
    rectangle.Move();
    rectangle.PrintInfo();
    Console.WriteLine("Area: " + rectangle.GetArea());
    Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());

    // create a new circle
    Circle circle = new Circle("Circle", "red", new int[] { 5, 5 }, 3);
    circle.PrintInfo();
    circle.Move();
    circle.PrintInfo();
    Console.WriteLine("Area: " + circle.GetArea());
    Console.WriteLine("Perimeter: " + circle.GetPerimeter());
}