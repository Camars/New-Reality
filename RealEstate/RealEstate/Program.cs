using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            
            List<Car> myCars = new List<Car>();
            List<House> myHouse = new List<House>();

            ConsoleKeyInfo info;

            Console.WriteLine("Would you like to add a Car or a House? (c/h)");
            //string answer = Console.ReadLine();
            info = Console.ReadKey();

            if (info.Key == ConsoleKey.C);
            {

                do
                {
                    Console.Clear();
                    var house = new House();
                    Console.WriteLine("Please enter the house's square footage");
                    house.SquareFoot = Console.ReadLine();
                    Console.WriteLine("Please enter the house's number of rooms");
                    house.NumRooms = Console.ReadLine();
                    Console.WriteLine("Please enter if the house is a condo(y/n)");
                    info = Console.ReadKey();
                    if (info.Key == ConsoleKey.Y)
                    {
                        house.Condo = true;
                    }
                    else
                    {
                        house.Condo = false;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Please enter the house's acreage");
                    house.Land = Console.ReadLine();
                    Console.WriteLine("Please enter number of bathrooms the house has");
                    house.NumBathrooms = Console.ReadLine();
                    Console.WriteLine("Please enter (y/n) if the house has a fireplace");
                    info = Console.ReadKey();
                    if (info.Key == ConsoleKey.Y)
                    {
                        house.FirePlace = true;
                    }
                    else
                    {
                        house.FirePlace = false;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to add another house? (y/n)");
                    info = Console.ReadKey();
                    myHouse.Add(house);

                }
                while (info.Key == ConsoleKey.Y);
            }
            else;
	        {

	
            Console.Clear();
            Console.WriteLine("Hit enter to see the house(s)");
            Console.ReadLine();

            foreach (var item in myHouse)
            {
                string condo;
                if (item.Condo == true)
                {
                    condo = "Yes";
                }
                else
                {
                    condo = "No";
                }

                string fire;
                if (item.FirePlace == true)
                {
                    fire = "Yes";
                }
                else
                {
                    fire = "No";
                }

                Console.WriteLine("Square footage:_______________ " + item.SquareFoot);
                Console.WriteLine("Number of rooms:______________ " + item.NumRooms);
                Console.WriteLine("Condo (t/f):__________________ " + condo);
                Console.WriteLine("Acreage:______________________ " + item.Land);
                Console.WriteLine("Number of Bathrooms:__________ " + item.NumBathrooms);
                Console.WriteLine("If it has a fireplace (t/f):__ " + fire);
                Console.WriteLine("------------------------------------");
            }
            Console.ReadLine();


            //-----------------------------------------------------------
            //To add cars to the Garage.


            do
            {
                Console.Clear();
                var car = new Car();
                Console.WriteLine("Please enter the car make:");
                car.Make = Console.ReadLine();
                Console.WriteLine("Please enter the car model");
                car.Model = Console.ReadLine();
                Console.WriteLine("Please enter the car year");
                car.Year = Console.ReadLine();
                Console.WriteLine("Please enter the car interior color");
                car.InteriorColor = Console.ReadLine();
                Console.WriteLine("Please enter the car exterior color");
                car.ExteriorColor = Console.ReadLine();
                myCars.Add(car);

                Console.WriteLine("Would you like to add another car? (y/n)");
                info = Console.ReadKey();

            } while (info.Key == ConsoleKey.Y);

            Console.Clear();
            Console.WriteLine("Hit enter to see the cars...");
            Console.ReadLine();

            foreach (var item in myCars)
            {
                Console.WriteLine("Make:   " + item.Make);
                Console.WriteLine("Model:   " + item.Model);
                Console.WriteLine("Year:   " + item.Year);
                Console.WriteLine("Interior Color:   " + item.InteriorColor);
                Console.WriteLine("Exterior Color:   " + item.ExteriorColor);
                Console.WriteLine("------------------------");

            }
            Console.ReadLine();
            }

        }
    }
}
