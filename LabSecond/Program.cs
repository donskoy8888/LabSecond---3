using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of the first side: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter lenght of the second side: ");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle myRectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Perimeter: {myRectangle.Perimeter}");
        Console.WriteLine($"Area: {myRectangle.Area}");
    }
}