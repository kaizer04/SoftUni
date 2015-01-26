using System;
/*Write an expression that checks if given integer is odd or even.*/

class ChecksOddOrEven
{
    static void Main()
    {
        int x;
        Console.Write("Please, enter a number: ");
        x = int.Parse(Console.ReadLine());
        //int y = x % 2;
        Console.WriteLine((x % 2) != 0);
    }
}

