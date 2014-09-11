using System;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();
    }
}
