/*Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].*/

namespace _03.InvalidRangeException
{
    using System;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            int start = 1;
            int end = 100;

            int number;
            Console.Write("Enter a number in int from 1 to 100: ");

            try
            {
                number = int.Parse(Console.ReadLine());
                if ((number < start) || (number > end))
                {
                    throw new InvalidRangeException<int>("Please enter a number in the range!", start, end);
                }
                else
                {
                    Console.WriteLine("Done! But try with exception!");
                }
            }
            catch (InvalidRangeException<int> exception)
            {
                Console.WriteLine("The range must be [{0}...{1}]!", exception.Start, exception.End);
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine();

            DateTime startDate = new DateTime(1850, 01, 01);
            DateTime endDate = DateTime.Now;

            DateTime dateTime;
            CultureInfo provider = CultureInfo.InvariantCulture;
            Console.Write("Enter your Birth Date (Format: 06/15/2008): ");

            try
            {
                dateTime = DateTime.ParseExact(Console.ReadLine(), "d", provider);
                if (dateTime < startDate)
                {
                    throw new InvalidRangeException<DateTime>("Are you centenarian?!!! Please consider the range!", startDate, endDate);
                }
                if (dateTime > endDate)
                {
                    throw new InvalidRangeException<DateTime>("Have you been birth in the feature?!!! Please consider the range!", startDate, endDate);
                }
                else
                {
                    Console.WriteLine("Done! But try with exception!");
                }

            }
            catch (InvalidRangeException<DateTime> exception)
            {
                Console.WriteLine("Range should be [{0}...{1}]!", exception.Start, exception.End);
                Console.WriteLine(exception.Message);
            }
        }
    }
}
