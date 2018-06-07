using System;

namespace Constructors
{
    class Vehicle
    {
        private readonly string _registrationNumber;

//        public Vehicle()
//        {
//            Console.WriteLine("The vehicle is being initialized");
//        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("The vehicle is being initialized {0}",registrationNumber);

        }


    }

}