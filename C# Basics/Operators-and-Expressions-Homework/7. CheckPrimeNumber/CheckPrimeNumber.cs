/*Write an expression that checks if given positive integer number n (n ? 100) is prime. E.g. 37 is prime.*/

using System;

class CheckPrimeNumber
{
    static void Main()
    {
        int n;
        int i;
        Console.Write("Enter a numebr n, 0<n<=100:\nn = ");
        n = int.Parse(Console.ReadLine());
        if ((n > 0) && (n <= 100))
        {
            if ((n == 1) || (n == 2) || (n == 3))
            {
                Console.WriteLine("{0} is prime number", n);
            }
            else
            {
                if ((n == 4) || (n == 9))
                {
                    Console.WriteLine("{0} is composite number", n);
                }
                else
                {
                    for (i = 2; i < Math.Sqrt(n); i++)
                    {
                        Console.WriteLine("{0} is {1}", n, (n % i) == 0 ? "composite number" : "prime number");
                        break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Please, enter n, 0<n<=100");
        }
    }
}

