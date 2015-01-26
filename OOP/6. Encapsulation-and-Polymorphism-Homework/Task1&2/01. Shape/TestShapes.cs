/*Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.*/

namespace _01.Shape
{
    using System;
    
    class TestShapes
    {
        public static void Main()
        {
            //var circle1 = new Circle(4);
            //Console.WriteLine(circle1.CalculateSurface());     
            Shape[] shapes =
            {
                new Circle(1),
                new Triangle(4,5),
                new Rectangle(5,3)
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("The surfase of {0} is {1:F2} square centimeters.", shapes[i].GetType().Name, shapes[i].CalculateSurface());
            }
            
            //foreach (var item in shapes)
            //{
            //    Console.WriteLine(item.CalculateSurface());
            //}
        }
    }
}
