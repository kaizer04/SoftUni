using System;
/*Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.*/

class CheksBit
{
    static void Main()
    {
        int x; Console.Write("Please, enter a number: ");
        x = int.Parse(Console.ReadLine());
        int y = 1;
        int mask = y << 3;
        Console.WriteLine("The third bit of {0} is: {1}", x, (x & mask) != 0 ? 1 : 0);
    }
}

