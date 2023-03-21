using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var myFirstCar = new Car();
            myFirstCar.Make = "Honda";
            myFirstCar.Model = "Accord";
            myFirstCar.Year = 1998;
            myFirstCar.EngineNoise = "chugchug";
            myFirstCar.HonkNoise = "meow";
            myFirstCar.IsDrivable = true;

            lot.Cars.Add(myFirstCar);

            var mySecondCar = new Car()
            {
                Make = "Acura",
                Model = "RSX Type S",
                Year = 2002,
                EngineNoise = "purr",
                HonkNoise = "bark",
                IsDrivable = false
            };

            lot.Cars.Add(mySecondCar);
            var myThirdCar = new Car(2008, "Jeep", "Liberty", "growl", "hiss", true);

            lot.Cars.Add(myThirdCar);

            myFirstCar.MakeEngineNoise(myFirstCar.EngineNoise);
            mySecondCar.MakeEngineNoise(mySecondCar.EngineNoise);
            myThirdCar.MakeEngineNoise(myThirdCar.EngineNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created is: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year : {car.Year} Make : {car.Make} Model : {car.Model}");
            }
        }
    }
}
