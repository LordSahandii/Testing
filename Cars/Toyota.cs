using System;
namespace Assignment3_Extended.Cars
{
    class Toyota : Car
    {
        public Toyota(string colour, int NumberofDoors, int Fuel, int Mileage, int MaxSpeed) : base(colour, NumberofDoors, Fuel, Mileage, MaxSpeed)
        {

        }
    }

    class Corolla : Toyota
    {
        private string EngineType;
        private int HP;

        





        public Corolla(string colour, int NumberofDoors, int Fuel,int Mileage,int MaxSpeed) : base(colour, NumberofDoors, Fuel, Mileage, MaxSpeed)
        {
            this.EngineType = "V4 Engine";
            this.HP = 180;
 
            
        }

        public void Disp()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Car's Info: ");
            Console.WriteLine("Type of Car : Corolla");
            Console.WriteLine("**********************");
        }

    }

}
