using System;
using ClassLibrary1;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trapezoid trapezoid = new Trapezoid(-3, 0);

            Console.WriteLine("P=" + trapezoid.GetPerimeter());
            Console.WriteLine("S=" + trapezoid.GetArea());
            Console.WriteLine("Point(0, 1) is " + trapezoid.DoesPointBelong(0, 1));
            Console.WriteLine("Point(6, 0) is " + trapezoid.DoesPointBelong(6, 0));
            Console.WriteLine("Point(12, 1) is " + trapezoid.DoesPointBelong(12, 1));

            Console.WriteLine("Trying to create invalid trpezoid...");
            try
            {
               Trapezoid invalidTrapezoid = new Trapezoid(0, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
