﻿using System;

internal class ZeroSubset
{
    private static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());

        if (a == 0 && b == 0 && c == 0 && d == 0 && e == 0)
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        else
        {
            if (a + b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            }
            if (a + b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            }
            if (a + b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            }
            if (a + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            }
            if (a + b + c == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            }
            if (a + b + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            }
            if (a + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            }
            if (a + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            }
            if (a + b == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, b);
            }
            if (a + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
            }
            if (a + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
            }
            if (a + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, e);
            }
            if (b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            }
            if (b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            }
            if (b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            }
            if (b + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, c);
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, d);
            }
            if (b + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);
            }
            if (c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
            }
            if (c + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, e);
            }
            if (d + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
            }
        }
        if (((a + b + c + d + e == 0) || (a + b + c + d == 0) || (a + b + c + e == 0) || (a + b + d + e == 0) || (a + c + d + e == 0) || (a + b + c == 0) || (a + b + d == 0) || (a + b + e == 0) || (a + c + d == 0) || (a + c + e == 0) || (a + d + e == 0) || (a + b == 0) || (a + c == 0) || (a + d == 0) || (a + e == 0) || (b + c + d + e == 0) || (b + c + d == 0) || (b + c + e == 0) || (b + d + e == 0) || (b + c == 0) || (b + d == 0) || (b + e == 0) || (c + d + e == 0) || (c + d == 0) || (c + e == 0) || (d + e == 0) || (d + e == 0)))
        {
            
        }
        else
        {
            Console.WriteLine("no zero subset");
        }
        Console.ReadLine();
    }
}