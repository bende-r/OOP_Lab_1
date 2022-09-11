using ClassLibrary;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2, 2, 4);

            Console.WriteLine("P=" + circle.GetPerimeter());
            Console.WriteLine("S=" + circle.GetArea());
            Console.WriteLine("Point(2, 2) is " + circle.DoesPointBelong(2, 2));
            Console.WriteLine("Point(6, 2) is " + circle.DoesPointBelong(6, 2));
            Console.WriteLine("Point(12, 2) is " + circle.DoesPointBelong(12, 2));

            Console.WriteLine("Trying to create invalid circle...");
            try
            {
                Circle invalidCircle = new Circle(2, 3, 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
