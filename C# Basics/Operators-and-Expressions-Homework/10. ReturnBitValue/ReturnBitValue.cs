using System;
/*Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.*/

class ReturnBitValue
{
    static void Main()
    {
        int v;
        int y = 1;
        int p;
        Console.Write("Please, enter a number v = ");
        v = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a position p = ");
        p = int.Parse(Console.ReadLine());
        int mask = y << p;
        //Console.WriteLine("The bit on position {0} of {1} is: {2}", p, v, (v & mask) != 0 ? 1 : 0);
        Console.WriteLine("v = {1}, p = {0}, -> {2}", p, v, (v & mask) != 0 ? true : false);
    }
}

