/*Write an expression that checks if given point (x,  y) is within a circle K(O, 5).*/
using System;

class CheckPointCircle
{
    static void Main()
    {
        float x;
        float y;
        //float r = 5;
        Console.Write("Enter point`s coordinates:\nx = ");
        x = float.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = float.Parse(Console.ReadLine());
        bool z = ((x * x) + (y * y)) <= 25;
        Console.WriteLine("The point is within a circle K(O, 5): {0}", z);
    }
}

