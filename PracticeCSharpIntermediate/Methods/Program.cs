
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           var number = int.Parse("agsgs");

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("point is at {0}, {1}", point.UpperX, point.UpperY);

                point.Move(100, 200);
                Console.WriteLine("point is at {0}, {1}", point.UpperX, point.UpperY);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred");
            }

        }

    }
}
