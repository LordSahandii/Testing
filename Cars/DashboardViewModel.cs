using System;
namespace Assignment3_Extended.Cars
{
    public class DashboardViewModel
    {
        public double Mileage;
        public FuelLevelEnum FuelLevel;
        public int Fuel;

        //public DashboardViewModel()
        //{
        //    FuelLevel = FuelLevelEnum.Unknown;
        //    Fuel = 0;
        //    Console.Write(FuelLevel);
        //}
    }

    public enum FuelLevelEnum
    {
        Unknown,  // = 0
        Empty,  // = 1
        Low,  // = 2
        Quarter,// = 3
        Half,
        ThreeForths,
        Full
    }
}
