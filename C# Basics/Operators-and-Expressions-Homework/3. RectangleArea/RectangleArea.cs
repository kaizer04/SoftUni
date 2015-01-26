using System;
/*Write an expression that calculates rectangle’s area by given width and height.*/

class RectangleArea
{
    static void Main()
    {
        Console.Write("Calculate rectangle’s area\nEnter width: ");
        uint x = Convert.ToUInt32(Console.ReadLine());
        Console.Write("Enter height: ");
        uint y = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("The rectangle’s area is: {0}", x*y);
    }
}

