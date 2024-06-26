using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        Bicycle myBicycle = new Bicycle();

        myCar.Move();       
        myBicycle.Move();   
    }
}
