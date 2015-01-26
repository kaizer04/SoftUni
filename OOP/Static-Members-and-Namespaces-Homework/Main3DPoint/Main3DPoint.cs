namespace Point3D
{
    using System;

    public class Main3DPoint
    {
        public static void Main()
        {
            TestTask123();

            TestTask4();
        }

        public static void TestTask4()
        {
            Path test1 = new Path();
            test1.AddPoint();
            test1.AddPoint(new Point(1, 2, 3));
            test1.AddPoint(4, 5, 6);


            Console.WriteLine(test1); // testing toString for a path

            PathStorage.WritePathToFile("test.txt", test1);

            Path readFromFile = PathStorage.ReadPathFromFile("test.txt");

            Console.WriteLine(readFromFile);
        }

        public static void TestTask123()
        {
            Point testPoint1 = new Point(0, 1, 2);
            Point testPoint2 = new Point(3, 4, 5);

            Console.WriteLine(testPoint1);
            Console.WriteLine(testPoint2);

            Console.WriteLine(Point.StartPoint);

            Console.WriteLine(Distance3DPoints.CalculateDistance(testPoint1, testPoint2));
        }
    }
}