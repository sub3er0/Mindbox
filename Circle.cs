using System;
using System.Collections.Generic;
using System.Text;

namespace calculateAreaLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle(double _radius) { Radius = _radius; }
        public double Square()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
