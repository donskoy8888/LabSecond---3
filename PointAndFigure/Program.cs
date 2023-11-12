using System;

class Program
{
    static void Main()
    {
        Point pointA = new Point(0, 0, "A");
        Point pointB = new Point(0, 1, "B");
        Point pointC = new Point(1, 1, "C");

        Figure triangle = new Figure(pointA, pointB, pointC);

        triangle.CalculatePerimeter();
    }
}