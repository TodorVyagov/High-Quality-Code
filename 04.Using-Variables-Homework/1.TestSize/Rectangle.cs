namespace TestRectangle
{
    using System;

    public class Rectangle // I do not think that Size is good name for class, maybe for property is good.
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static Rectangle GetRotatedRectangle(Rectangle rectangle, double angleOfRotation)
        {
            //I don't understand the expression, but tried to simplify it and make it easier to read.
            double sinus = Math.Abs(Math.Sin(angleOfRotation));
            double cosinus = Math.Abs(Math.Cos(angleOfRotation));

            double width = cosinus * rectangle.Width + sinus * rectangle.Height;
            double height = sinus * rectangle.Width + cosinus * rectangle.Height;

            return new Rectangle(width, height);
        }
    }
}
