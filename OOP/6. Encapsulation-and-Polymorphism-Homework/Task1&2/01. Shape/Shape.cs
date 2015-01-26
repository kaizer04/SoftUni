namespace _01.Shape
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Width must be greater than 0!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Height must be greater than 0!");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();

    //    public abstract void CalculateSurface()
    //    {
    //        Console.WriteLine("The surface of the " + this.GetType().Name + " is ");
    //    }
    }
}
