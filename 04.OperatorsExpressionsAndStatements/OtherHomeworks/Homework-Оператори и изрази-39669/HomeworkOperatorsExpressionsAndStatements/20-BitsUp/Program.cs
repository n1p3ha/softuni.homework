﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_BitsUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                {
                    if ((index % step == 1) || (step == 1 && index > 0))
                    {
                        num = num | (1 << bit);
                    }
                    index++;
                }
                Console.WriteLine(num);
            }
        }
    }
}
