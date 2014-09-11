namespace TestRectangle
{
    using System;

    class TestRectangle
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(5, 12);
            Console.WriteLine("Created rectangle with (Width: {0}, Height: {1}).", rectangle.Width, rectangle.Height);

            var rotatedRectangle = Rectangle.GetRotatedRectangle(rectangle, Math.PI / 2); // PI/2 is 90 degrees
            Console.WriteLine("Rotated rectangle(90 degrees) with (Width: {0}, Height: {1}).", 
                rotatedRectangle.Width, rotatedRectangle.Height);

        }
    }
}
