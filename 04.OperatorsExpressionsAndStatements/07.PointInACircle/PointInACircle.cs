﻿using System;
class PointInACircle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        bool isInsideCircle = (x * x) + (y * y) <= (2 * 2);

        Console.WriteLine("inside = " + isInsideCircle);
        Console.ReadLine();
    }
}