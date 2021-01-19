using System;
using System.Collections.Generic;
using System.Text;

namespace calculateAreaLibrary
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double _A, double _B, double _C) { A = _A; B = _B; C = _C; }
        public double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        // проверка на прямоугольность
        public bool IsRectangular()
        {
            if (A > B && A > C)
            {
                if (A == (Math.Sqrt(B * B + C * C)))
                    return true;
                else
                    return false;
            } else if (B > A && B > C)
            {
                if (B == (Math.Sqrt(A * A + C * C)))
                    return true;
                else
                    return false;
            } else if (C > B && C > A)
            {
                if (C == (Math.Sqrt(A * A + B * B)))
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
