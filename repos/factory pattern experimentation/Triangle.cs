using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern_experimentation
{
    class Triangle : IShape
    {
        private readonly double _length;

        public Triangle(double length)
        {
            _length = length;
        }

        public double GetArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(_length, 2);
        }
    }
}
