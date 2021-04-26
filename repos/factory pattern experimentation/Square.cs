using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern_experimentation
{
    class Square : IShape
    {
        private readonly double _length;

        public Square(double length)
        {
            _length = length;
        }

        public double GetArea()
        {
            return _length * _length;
        }
    }
}
