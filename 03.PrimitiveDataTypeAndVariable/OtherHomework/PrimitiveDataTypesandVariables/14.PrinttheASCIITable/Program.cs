﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrinttheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            
                for (int i = 0; i <= 255; i++)
			{
			 
                    Console.WriteLine(i + " : " + (char)i);
			}
        }
    }
}