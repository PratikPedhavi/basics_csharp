using System;
using System.Collections.Generic;
using static operations.operations;

namespace basics
{
    class Car
    {
        public string brand;
        public float cost;
        public int distanceTravelled = 0; 

        public Car(string _brand, float _cost)
        {
            brand = _brand;
            cost = _cost;
        }

        public void travel(int distance)
        {
            distanceTravelled += distance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Hello World!
            Console.WriteLine("Hello World! \n");

            // Looping
            List<double> squares = new List<double>();

            for (int i = 1; i <= 3; i++)
            {
                // Calling method from other file
                double result = Squared(i);
                Console.WriteLine(i + " squared equals " + result);
                Console.WriteLine(i + " + " + result + " = " + Addition(Convert.ToDouble(i),result));
                squares.Add(result);
            }
            // Lists
            Console.WriteLine("\n" + String.Join("; ",squares));

            // Objects
            Car car1 = new Car("mercedes", 2000);
            car1.travel(50);

            Console.WriteLine("\n Car1 Total distance travelled: " + car1.distanceTravelled);

            Car car2 = new Car("ferrari", 5000);
            car2.travel(10);

            Console.WriteLine("\n Car2 Total distance travelled: " + car2.distanceTravelled);
        }        
    }
}
