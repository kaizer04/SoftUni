/*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;

class CheckPointCircleAndRectangle
{
    static void Main()
    {
        float x;
        float y;
        Console.Write("Enter point`s coordinates:\nx = ");
        x = float.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = float.Parse(Console.ReadLine());
        bool m = (((x <= 5) && (x >= -1)) && ((y <= 1) && (y >= -1)));
        bool z = ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 9);
        Console.WriteLine((!m && z) ? "The point is within the circle K((1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2)" : "The point is not within a circle K((1,1), 3) or out of the rectangle R(top=1, left=-1, width=6, height=2)");
    }
}
