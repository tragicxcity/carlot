using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lot = new CarLot();

            CarLot TimeToGo;
               
                var car1 = new Car(2021, "Toyota", "Corolla", "Vroom", "Beep", true);

                lot.Cars.Add(car1);

                var car2 = new Car(2020, "Nissan", "Frontier", "Brooom", "honk", true);

                lot.Cars.Add(car2);

                var car3 = new Car(1908, "Ford", "Model T", "Drooom", "Honk", false);

                lot.Cars.Add(car3);
               
            



            //Set the properties for each of the cars

            //Call each of the methods for each car
            car1.MakeEngineNoise();
            car2.MakeEngineNoise();
            car3.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {

                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Module: {car.Model}");

            }

        }
    }
}
