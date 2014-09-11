using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        /// <summary>
        /// Initializes a new instance of <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width of rectangle.</param>
        /// <param name="height">The width of rectangle.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Returns the width of rectangle.
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.ValidateSide(value);
                this.width = value;
            }
        }

        /// <summary>
        /// Returns the height of rectangle.
        /// </summary>
        public double Height {
            get
            {
                return this.height;
            }
            private set
            {
                this.ValidateSide(value);
                this.height = value;
            }
        }

        private void ValidateSide(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Invalid value! Side cannot be negative!");
            }
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle.
        /// </summary>
        /// <returns>The perimeter.</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        /// <returns>The area.</returns>
        public override double CalculateArea()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
