﻿using System;
class PointInCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) < (1.5 * 1.5);
        bool isOutsideRectangle = x > 1 || x < 5 && y > -1 || y < 1;

        if (x == 0 || y == 0)
        {
            Console.WriteLine("no");
        }
        else if (isInCircle == true && isOutsideRectangle == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        Console.ReadLine();
    }
}