using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double circleRadius)
    {
        Radius = circleRadius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {

    Console.WriteLine("\n[1]Area of a circle\n[2]Area of a rectangle");
    Console.Write("Enter your option =>: ");
    int option = int.Parse(Console.ReadLine());
    switch (option){
        case 1:
        Console.Write("Enter radius =>: ");
        int radius = int.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        double circleArea = circle.GetArea();
        Console.WriteLine("Area of Circle: "+circleArea);  
        break;

        case 2:
        Console.Write("Enter Length =>: ");
        int l = int.Parse(Console.ReadLine());

        Console.Write("Enter Breadth =>: ");
        int b = int.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(l, b);
        double rectangleArea = rectangle.GetArea();
        Console.WriteLine("Area of Rectangle: "+rectangleArea); 
        break;

        default:
         Console.WriteLine("Invalid Option - Enter 1 for Circle, 2 for Rectangle");
         break;

    }

      
}

}
