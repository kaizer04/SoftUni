/*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Calculate trapezoid’s area\nEnter side a = ");
        uint a = Convert.ToUInt32(Console.ReadLine());
        Console.Write("Enter side b = ");
        uint b = Convert.ToUInt32(Console.ReadLine());
        Console.Write("Enter height h = ");
        uint h = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("The trapezoid’s area is: {0}", (a + b) * h / 2);
    }
}

