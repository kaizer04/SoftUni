using System;
/*We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	n = 5 (00000101), p=2, v=0 -> 1 (00000001)*/

class ModifieValueBit
{
    static void Main()
    {
        int n;
        int y = 1;
        int p;
        int v;
        int m;
        Console.Write("Please, enter a number n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a position p = ");
        p = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for the bit at the position p, (v = 0 or 1) v = ");
        v = int.Parse(Console.ReadLine());
        int mask = y << p;
        if (v == 0)
        {
            m = n & (~mask);
        }
        else
        {                    
           m = n | (mask);                
        }
        //     Console.WriteLine("Please, enter a corect value for v");
        //int mask = y << p;
        //b = (n & mask) != 0 ? 1 : 0);
        Console.WriteLine("n = {0}, p = {1}, v = {2} -> {3}", n, p, v, m);
    }
}

