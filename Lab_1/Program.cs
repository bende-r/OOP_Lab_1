using System;
using ClassLibrary1;

namespace Lab_1
{
    internal class Program
    {
        /// <summary>
        /// Создания трапеции по координатам.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double X1,X2;
            ConsoleKeyInfo Key;

            while (true)
            {
                Console.WriteLine("Please, enter X1 and X2");
                X1 = Convert.ToDouble(Console.ReadLine());
                X2 = Convert.ToDouble(Console.ReadLine());

                Trapezoid trapezoid = new Trapezoid(X1, X2);

                Console.WriteLine("P = " + trapezoid.GetPerimeter());
                Console.WriteLine("S = " + trapezoid.GetArea());
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

                Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
