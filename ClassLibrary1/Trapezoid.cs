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

        private int v;
        public int V
        {
            get { return v; }
            set
            {
                if (value > 0) v = value; 
            }
        }
        /// <summary>
        /// Создание трапеции по координатам вершин
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <exception cref="Exception"></exception>
        public Trapezoid(double x1, double x2)
        {
            X1 = x1;
            X2 = x2;
            if (!DoesExist()) throw new ArgumentException("Cannot create the trapezoid with initial values");
        }

        /// <summary>
        /// Вычисление периметра трапеции
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
           double k = Math.Sqrt(2) / 2;
            double ed1 = Math.Sin(X1) * Math.Sin(X1) * (1 - k * k);
            double ed2 = Math.Sin(X2) * Math.Sin(X2) * (1 - k * k);
            double e1 = (2 * Math.Sin(X1 / 2) + (Math.PI * X1 / 180 - 2 * Math.Sin(X1 / 2)) * k) * (2 * Math.Sin(X1 / 2) + (Math.PI * X1 / 180 - 2 * Math.Sin(X1 / 2)) * k);
            double e2 = (2 * Math.Sin(X2 / 2) + (Math.PI * X2 / 180 - 2 * Math.Sin(X2 / 2)) * k) * (2 * Math.Sin(X2 / 2) + (Math.PI * X2 / 180 - 2 * Math.Sin(X2 / 2)) * k);
            double l = Math.Sqrt(2) * Math.Sqrt(Math.Abs( e2 - ed2)) - Math.Sqrt(2) * Math.Sqrt(Math.Abs (e1 - ed1)) + Math.Abs(X1 - X2) + (Math.Cos(X1) + Math.Cos(X2));

            return Math.Abs(l);
        }

        /// <summary>
        /// Вычисление площади периметра
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.Abs(Math.Sin(X2) - Math.Sin(X1));
        }

        public Belonging DoesPointBelong(double x, double y)
        {
            if (Math.Cos(x) < y) return Belonging.Out;
            if (Math.Cos(x) > y) return Belonging.In;
            return Belonging.OnBorder;
        }


        /// <summary>
        /// Проверка существования фигуры
        /// </summary>
        /// <returns></returns>
        private bool DoesExist()
        {
            if (Math.Abs(X1-X2)>0) return true;
            return false;
        }
       
    }
}