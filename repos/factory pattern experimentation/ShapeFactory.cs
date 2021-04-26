using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern_experimentation
{
    class ShapeFactory
    {
        private ShapeFactory()
        {
        }

        private static ShapeFactory _instance;
        public static ShapeFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ShapeFactory();
                }

                return _instance;
            }
        }

        public IShape Create(string shape, double parameter)
        {
            switch (shape.ToLower())
            {
                case "square":
                    return new Square(parameter);
                case "circle":
                    return new Circle(parameter);
                case "triangle":
                    return new Triangle(parameter);
                default:
                    throw new ArgumentOutOfRangeException(nameof(shape));
            }
        }
    }
}
