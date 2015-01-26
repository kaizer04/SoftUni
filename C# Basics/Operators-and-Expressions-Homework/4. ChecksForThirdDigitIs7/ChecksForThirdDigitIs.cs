using System;
/*Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.*/

class ChecksForThirdDigitIs
{
    static void Main()
    {
        int x;
        
        Console.Write("Please, enter a number: ");
        x = int.Parse(Console.ReadLine());
        if (x < 0)
        {
            x = x * (-1);
        }
        int y = x / 100;
        int z = y % 10;
        Console.WriteLine("The third digit (right-to-left) is 7: {0}", z == 7);
    }
}

