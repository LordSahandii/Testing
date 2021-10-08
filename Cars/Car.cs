using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Extended.Cars
{
    class Car
    {
        private string colour;
        private int NumberofDoors;
        private Dashboard dashboard;
        private int Fuel;
        private int Mileage;
        private int MaxSpeed;
        



       public Car()
        {
            this.dashboard = new Dashboard();

        }
        public Car(string colour, int NumberofDoors, int Fuel, int Mileage, int MaxSpeed)
        {
            this.colour = colour;
            this.NumberofDoors = NumberofDoors;
            this.Fuel = Fuel;
            this.Mileage = Mileage;
            this.MaxSpeed = MaxSpeed;
            
            
            //this.dashboard.Mileage = Mileage;
            //this.dashboard.fuelLevel = Fuel;
        }
        public Dashboard letsee()
        {
            
            return new Dashboard()
            {
                Mileage = this.Mileage
            };
        }

        public void Display()
        {
            
            Console.WriteLine("Number of the doors : {0}", this.NumberofDoors);
            Console.WriteLine("Colour of the car : {0}", this.colour);
            Console.WriteLine("Dashboard View");
            Console.WriteLine("Mileage: {0}", this.Mileage);
            Console.WriteLine("Fuel: {0}", GetFuel());
            Console.WriteLine("Max Speed : {0}", MaxSpeed);
            
        }

        private FuelLevelEnum GetFuel()
        {
            var fuellevel = this.Fuel;
            if (fuellevel == 0)
                return FuelLevelEnum.Empty;
            else if (fuellevel > 0 && fuellevel <= 25)
                return FuelLevelEnum.Low;
            else if (fuellevel > 25 && fuellevel < 50)
                return FuelLevelEnum.Quarter;
            else if (fuellevel == 50)
                return FuelLevelEnum.Half;
            else if (fuellevel > 50 && fuellevel <= 99)
                return FuelLevelEnum.ThreeForths;
            else if (fuellevel == 100)
                return FuelLevelEnum.Full;
            else
                return FuelLevelEnum.Unknown;
        }
    }
}
