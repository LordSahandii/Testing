using System;
using Assignment3_Extended.Cars;

namespace Assignment3_Extended
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            object[] listofCars;
            int Mileage, MaxSpeed, Doors, Fuel;
            string Colour;
            bool x = true;
            while (x)
            {
                Console.WriteLine("1-Add a Car!");
                Console.WriteLine("2-Display Cars");
                Console.WriteLine("3-Exit");

                int userInput = Console.Read();

                if (userInput == 1)
                {
                    Console.WriteLine("1-Add a Corolla\n2-Add a Prius");
                    userInput = Console.Read();

                    Console.WriteLine("What Colour is it? ");
                    Colour = Console.ReadLine();
                    Console.WriteLine("How many doors does it have? ");
                    Doors = Console.Read();
                    Console.WriteLine("What is the maximum speed? ");
                    MaxSpeed = Console.Read();
                    Console.WriteLine("How much Gas do u have currently? ");
                    Fuel = Console.Read();
                    Console.WriteLine("What is the mileage on the car? ");
                    Mileage = Console.Read();

                    if (userInput == 1)
                    {

                    }

                }
                else
                {
                    Console.WriteLine("Good Bye");
                    x = false;
                }
            }

          

            /*int h = carss.ma();
            Console.WriteLine(h);*/
            var Toy = new Corolla("Blue", 5,50,550,260);
            Toy.Display();
            Toy.Disp();
            

           
            


            var hello = new MainClass();
            hello.EncapsulationMode();
        }

        public void EncapsulationMode()
        {
            Console.WriteLine("I am Secured");
            
            
        }
    }

    
}
