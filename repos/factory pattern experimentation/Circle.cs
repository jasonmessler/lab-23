﻿using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern_experimentation
{
    class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
