using System;
/*Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/

class Div7and5
{
    static void Main()
    {
        int x;
        Console.Write("Please, enter a number: ");
        x = int.Parse(Console.ReadLine());
        //int y = x % 7;
        //int z = x % 5;
        Console.WriteLine(((x % 7 == 0) && (x % 5 == 0)) ? "The number divides by 7 and 5" : "The number is not divide by 7 and 5");
    }
}

