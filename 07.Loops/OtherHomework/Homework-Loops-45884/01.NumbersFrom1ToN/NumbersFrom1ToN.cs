﻿using System;


class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }
}

