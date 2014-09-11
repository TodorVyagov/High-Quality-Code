using System;

namespace Abstraction
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Returns the radius of circle.
        /// </summary>
        public double Radius {
            get
            {
                return this.radius;
            }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative or equal to zero!");
                }

                this.radius = value;
            }
        }

        /// <summary>
        /// Calculates the perimeter of the circle.
        /// </summary>
        /// <returns>The perimeter.</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area.</returns>
        public override double CalculateArea()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
