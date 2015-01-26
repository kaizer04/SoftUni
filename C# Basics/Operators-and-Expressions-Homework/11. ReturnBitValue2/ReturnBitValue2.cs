using System;
/*Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 -> value=1.*/

class ReturnBitValue2
{
    static void Main()
    {
        int i;
        int y = 1;
        int b;
        Console.Write("Please, enter a number i = ");
        i = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a position b = ");
        b = int.Parse(Console.ReadLine());
        int mask = y << b;
        //Console.WriteLine("The bit on position {0} of {1} is: {2}", b, i, (i & mask) != 0 ? 1 : 0);
        Console.WriteLine("i = {1}, b = {0}, -> value = {2}", b, i, (i & mask) != 0 ? 1 : 0);
    }
}

