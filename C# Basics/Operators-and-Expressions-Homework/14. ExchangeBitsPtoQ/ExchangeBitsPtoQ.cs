/** Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.*/

using System;

class ExchangeBitsPtoQ
{
    static void Main()
    {
        uint i; // 00000000000000000000000000000101 i = 5
                // 01000000000000000000000000000100 new i = 1073741828
        uint y = 1;
        int p1;
        int p2;
        uint k;
        int n;
        Console.Write("Please, enter a number i = ");
        i = uint.Parse(Console.ReadLine());
        Console.Write("Please, enter the start positon of the first bits you want exchange, (0 < = p1 < = 31) p1 = ");
        p1 = int.Parse(Console.ReadLine());
        Console.Write("Please, enter how many bits you want exchange (0 < k < = 31-p1) k = ");
        k = uint.Parse(Console.ReadLine());
        Console.WriteLine("p1 + k = {0}", p1 + k);
        Console.Write("Please, enter the start positon of the second bits you want exchange, (p1+k < p2 <= 31-k) p2 = ");
        p2 = int.Parse(Console.ReadLine());
        for (n = 0; n < k; n++)
        {
            uint mask1 = y << (p1 + n);
            int v1 = ((i & mask1) != 0 ? 1 : 0);
            uint mask2 = y << (p2 + n);
            int v2 = ((i & mask2) != 0 ? 1 : 0);
            int v = v1;
            v1 = v2;
            v2 = v;
            if (v1 == 0)
            {
                i = i & (~mask1);
            }
            else
            {
                i = i | (mask1);
            }
            if (v2 == 0)
            {
                i = i & (~mask2);
            }
            else
            {
                i = i | (mask2);
            }
        }
                Console.WriteLine("Exchanged Bits number i = {0}", i);
        //Console.WriteLine("i = {1}, p = {0}, -> value = {2}", p, i, (i & mask) != 0 ? 1 : 0);
    }
}

