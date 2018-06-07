using System;

namespace Constructors
{
    class Car : Vehicle
    {
        public Car(string somenumber)
            : base(somenumber)

        {
            Console.WriteLine("The car is being initialised {0}",somenumber);
        }
    }
}