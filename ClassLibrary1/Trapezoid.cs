using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Trapezoid
    {
        public enum Belonging
        {
            Out,
            In,
            OnBorder
        }

        public double X1 { get; private set; }
        public double X2 { get; private set; }

        public Trapezoid(double x1, double x2)
        {
            X1 = x1;
            X2 = x2;
            if (!DoesExist()) throw new Exception("Cannot create the trapezoid with initial values");
        }

        public float GetPerimeter()
        {
            return (float)Math.Abs(X1 - X2) + ((float)Math.Cos(X1) + (float)Math.Cos(X2)) + ((float)Math.Sqrt(2) * (float)Math.Sqrt((float)Math.Pow((2 * (float)Math.Sin((X2 + (float)Math.PI / 2) / 2) + ((float)Math.PI * (X2 + (float)Math.PI / 2) / 180 - 2 * (float)Math.Sin((X2 + (float)Math.PI / 2) / 2))) * ((float)Math.Sqrt(2) / 2), 2) - (float)Math.Pow((float)Math.Sin(X2 + (float)Math.PI / 2), 2) * (1 - ((float)Math.Sqrt(2) / 2) * ((float)Math.Sqrt(2) / 2))))  /**/- ((float)Math.Sqrt(2) * (float)Math.Sqrt((float)Math.Pow((2 * (float)Math.Sin((X1 + (float)Math.PI / 2) / 2) + ((float)Math.PI * (X1 + (float)Math.PI / 2) / 180 - 2 * (float)Math.Sin((X1 + (float)Math.PI / 2) / 2))) * ((float)Math.Sqrt(2) / 2), 2) - (float)Math.Pow((float)Math.Sin(X1 + (float)Math.PI / 2), 2) * (1 - ((float)Math.Sqrt(2) / 2) * ((float)Math.Sqrt(2) / 2))));
        }

        public double GetArea()
        {
            return -(float)Math.Sin(X1) + (float)Math.Sin(X2);
        }

        public Belonging DoesPointBelong(double x, double y)
        {
            if (Math.Cos(x) < y) return Belonging.Out;
            if (Math.Cos(x) > y) return Belonging.In;
            return Belonging.OnBorder;
        }

        private bool DoesExist()
        {
            if (Math.Abs(X1-X2)>0) return true;
            return false;
        }
    }
}

//Math.Abs(X1 - X2) + (Math.Cos(X1) + Math.Cos(X2)) + (Math.Sqrt(2) * Math.Sqrt(Math.Pow((2 * Math.Sin((X2 + Math.PI / 2) / 2) + (Math.PI * (X2 + Math.PI / 2) / 180 - 2 * Math.Sin((X2 + Math.PI / 2) / 2))) * (Math.Sqrt(2) / 2), 2) - Math.Pow(Math.Sin(X2 + Math.PI / 2), 2) * (1 - (Math.Sqrt(2) / 2) * (Math.Sqrt(2) / 2))))  /**/- (Math.Sqrt(2) * Math.Sqrt(Math.Pow((2 * Math.Sin((X1 + Math.PI / 2) / 2) + (Math.PI * (X1 + Math.PI / 2) / 180 - 2 * Math.Sin((X1 + Math.PI / 2) / 2))) * (Math.Sqrt(2) / 2), 2) - Math.Pow(Math.Sin(X1 + Math.PI / 2), 2) * (1 - (Math.Sqrt(2) / 2) * (Math.Sqrt(2) / 2))));
