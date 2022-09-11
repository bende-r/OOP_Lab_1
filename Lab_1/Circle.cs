using System;

namespace ClassLibrary
{
    public class Circle
    {
        public enum Belonging
        {
            Out,
            In,
            OnBorder
        }

        public double X { get; private set; }
        public double Y { get; private set; }
        public double R { get; private set; }

        public Circle(double x, double y, double r)
        {
            X = x;
            Y = y;
            R = r;
            if (!DoesExist()) throw new Exception("Cannot create the circle with initial values");
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        public double GetArea()
        {
            return Math.PI * R * R;
        }

        public Belonging DoesPointBelong(double x, double y)
        {
            double distance = Math.Pow(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2), 0.5);
            if (distance > R) return Belonging.Out;
            if (distance < R) return Belonging.In;

            return Belonging.OnBorder;
        }

        private bool DoesExist()
        {
            if (R > 0) return true;
            return false;
        }
    }
}
