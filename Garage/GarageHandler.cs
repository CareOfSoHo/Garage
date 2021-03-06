﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage
{
    public class GarageHandler : IGarageHandler
    {
        //private readonly IGarage<IVehicle> garage;
        //private readonly T[] vehickes;

        /* handlern ska skicka in vehicles i garagets Array
         * handlern ska hämta information från Garagets Array
         * handlern ska tabort Vehicles från Arrayen
         */
        private Vehicle[] vehiclesArr;


        private List<Vehicle> vehicles;

        public GarageHandler()
        {

            ////Skapar instans av vehicle lista
            //vehicles = new List<Vehicle>();

            ////hårdkodat
            //Vehicle v = new AirPlane("AIR123", "White", 8, 1, "Black Hawk");
            //vehicles.Add(v);
            //v = new Boat("BOAT98", "Purple", 0, 30);
            //vehicles.Add(v);
            //v = new Bus("BUS848", "RED", 4, 53);
            //vehicles.Add(v);
            //v = new Car("CAR456", "Black", 4, 450);
            //vehicles.Add(v);
            //v = new Motorcycle("MC678", "Gray", 2, 1700);
            //vehicles.Add(v);

            vehiclesArr = new Vehicle[]
           {
                new AirPlane("SAS987", "Grey", 16, 4, "AirBus") as Vehicle,
                new AirPlane("AIR643", "Gold", 30, 8, "727") as Vehicle,
                new Boat("kak234", "Blue", 0, 35) as Vehicle,
                new Boat("sos124", "white", 0, 305) as Vehicle
           };

            for (int i = 0; i < vehiclesArr.Length; i++)
            {
                Console.WriteLine(vehiclesArr[i]);
            }
            //foreach (var item in vehiclesArr)
            //{
            //    //Console.WriteLine(item.GetType().ToString() + " Color: " + item.Color + " RegNo: " + item.RegNo);
            //    Console.WriteLine(item);
            //}

        }

        public void Menu()
        {
            while (true)
            {
                char choise = GetMenuChoise();
                switch (choise)
                {
                    case '1':
                        ParkVehicle();
                        break;
                    case '2':
                        ListAllVehicles();

                        break;
                    case '3':
                        SearchVehicle();
                        break;
                    case '4':
                        GetVehicle();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        private void GetVehicle()
        {
            Console.WriteLine("PICK UP YOUR VEHICLES\n");
            Console.WriteLine("Provide your registration number: ");
            //sök på regnr
            string searchWord = Console.ReadLine().ToUpper();
            if (searchWord != "")
            {
                if (vehicles.Count > 0)
                {
                    int noOfPosts = vehicles.Count - 1; //antal poster i listan. -1 för att jämföra med i i for-loopen
                    int counter = 0; // finns det träff på regnr(sökordet), räknare

                    //loopar igenom vehicles listan
                    for (int i = 0; i < vehicles.Count; i++)
                    {
                        if (vehicles[i].RegNo.ToUpper().Contains(searchWord))
                        {
                            Console.WriteLine("The vehicle is in the garage.");
                            Console.WriteLine("It is " + vehicles[i].Color + " and it is a " + vehicles[i].GetType() + "\n\n");
                            Console.WriteLine("Do you want to check out your vehicle? type Y/N");
                            string checkoutVehicle = Console.ReadLine().ToUpper();

                            if (checkoutVehicle == "Y")
                            {
                                vehicles.RemoveAt(i);
                                counter--; //en sökträff  mindre
                                Console.WriteLine("WELCOME BACK\n");
                            }
                            else
                            {
                                Console.WriteLine("We are keeping your vehicle, thank you\n");
                            }
                            counter++; //om sökträff
                        }
                        else
                        {
                            if ((i == noOfPosts) && (counter == 0)) //loopat till sista posten och räknare för träff på sökordet är 0
                                Console.WriteLine("Your vehicle is not here");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The garage is empty");
                }
            }
            else
            {
                Console.WriteLine("You did not provide your registration number");
            }

        }

        private void SearchVehicle()
        {
            Console.WriteLine("Ange ditt registreringsnummer: ");
            //sök på regnr
            string searchWord = Console.ReadLine().ToUpper();
            if (searchWord != "")
            {
                if (vehicles.Count > 0)
                {
                    int noOfPosts = vehicles.Count - 1; //antal poster i listan. -1 för att jämföra med i i for-loopen
                    int counter = 0; // finns det träff på regnr(sökordet), räknare

                    //loopar igenom vehicles listan
                    for (int i = 0; i < vehicles.Count; i++)
                    {
                        if (vehicles[i].RegNo.ToUpper().Contains(searchWord))
                        {
                            Console.WriteLine("The vehicle is in the garage.");
                            Console.WriteLine("It is " + vehicles[i].Color + " and it is a " + vehicles[i].GetType() + "\n\n");
                            counter++; //om sökträff
                        }
                        else
                        {
                            if ((i == noOfPosts) && (counter == 0)) //loopat till sista posten och räknare för träff på sökordet är 0
                                Console.WriteLine("Your vehicle is not here");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The garage is empty");
                }
            }
            else
            {
                Console.WriteLine("You did not provide your registration number");
            }

        }

        private void ListAllVehicles()
        {
            if (vehiclesArr.Length <= 0)
            {
                Console.WriteLine("The garage is empty");
            }
            else
            {
                Console.WriteLine("LISTED VEHICLES IN THE GARAGE:");
                foreach (var item in vehiclesArr)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("**********");
            }

        }

        private void ParkVehicle()
        {
            bool run = true;
            string regNo, color, model;
            int noOfWheels, numberofEngines, cylVol, noOfSeats, hrsPwr;
            char vehicleType;



            //method for user input Vehicle Base
            UserInputforBase(out regNo, out color, out noOfWheels, out vehicleType);

            while (run)
            {
                switch (vehicleType)
                {
                    case '1':
                        {
                            Console.WriteLine("Please, provide the model of your Airplane");
                            model = Console.ReadLine();
                            Console.WriteLine("Please, provide the number of Engines on your Airplane");

                            int.TryParse(Console.ReadLine(), out numberofEngines);
                            Vehicle v = new AirPlane(regNo, color, noOfWheels, numberofEngines, model);
                            //vehicles.Add(v);
                            //vehiclesArr.SetValue(v.RegNo, v.Color, v.NoOfWheels, numberofEngines, model);
                            //vehiclesArr.Append(v.RegNo, v.Color, v.NoOfWheels, numberofEngines, model);

                         
                            
                            //StringBuilder strB = new StringBuilder(regNo +":"+ color + ":" + noOfWheels + ":" + numberofEngines + ":" + model);
                            //Console.WriteLine("stringbuilder " + strB);


                            if (vehiclesArr.Length == 0)
                            {
                                vehiclesArr = new Vehicle[]
                                {
                                new AirPlane(regNo, color, noOfWheels, numberofEngines, model) as Vehicle
                                };
                            }
                            else
                            {
                                int lastIndex;
                                lastIndex = vehiclesArr.Length;

                               // vehiclesArr[lastIndex] = new AirPlane(regNo, color, noOfWheels, numberofEngines, model) as Vehicle;
                                
                                //string appendToArray = (regNo + " " + color + " " + noOfWheels + "" + numberofEngines + "" + model);
                                    
                                for (int i = 0; i < vehiclesArr.Length; i++)
                                {
                                    //vehiclesArr[i].RegNo = regNo;
                                    //vehiclesArr[i].Color = color;
                                    //vehiclesArr[i].NoOfWheels = noOfWheels;
                                    //vehiclesArr[lastIndex].RegNo = regNo;
                                    //vehiclesArr[lastIndex].Color = color;
                                    //vehiclesArr[lastIndex].NoOfWheels = noOfWheels;
                                }
                               
                                //vehiclesArr[lastIndex].NumberofEngines = numberofEngines;
                                //vehiclesArr[lastIndex].Model = model;

                            }
                            

                            Console.WriteLine("This is what you checked in to the garage: " + v);

                            run = false;
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Please, provide the Cylindervolume on your Boat");

                            int.TryParse(Console.ReadLine(), out cylVol);
                            Vehicle v = new Boat(regNo, color, noOfWheels, cylVol);
                            //vehicles.Add(v);
                            vehiclesArr.Append(v);

                            Console.WriteLine("This is what you checked in to the garage: " + v);

                            run = false;
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("Please, provide the number of seats on your Bus");

                            int.TryParse(Console.ReadLine(), out noOfSeats);
                            Vehicle v = new Bus(regNo, color, noOfWheels, noOfSeats);
                            //vehicles.Add(v);
                            vehiclesArr.Append(v);

                            Console.WriteLine("This is what you checked in to the garage: " + v);

                            run = false;

                            break;
                        }
                    case '4':
                        {
                            Console.WriteLine("Please, provide the horsepowers of your car");

                            int.TryParse(Console.ReadLine(), out hrsPwr);

                            Vehicle v = new Car(regNo, color, noOfWheels, hrsPwr);
                            //vehicles.Add(v);
                            vehiclesArr.Append(v);

                            Console.WriteLine("This is what you checked in to the garage: " + v);

                            run = false;

                            break;
                        }
                    case '5':
                        {
                            Console.WriteLine("Please, provide the horsepowers of your MC");

                            int.TryParse(Console.ReadLine(), out hrsPwr);

                            Vehicle v = new Motorcycle(regNo, color, noOfWheels, hrsPwr);
                            //vehicles.Add(v);
                            vehiclesArr.Append(v);

                            Console.WriteLine("This is what you checked in to the garage: " + v);

                            run = false;

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter some valid input (1, 2, 3, 4, 5)");
                            run = false;

                            break;
                        }

                }
            }
        }

        #region refactor to interface
        //refactor to interface
        public virtual void UserInputforBase(out string regNo, out string color, out int noOfWheels, out char vehicleType)
        {
            Console.WriteLine("Please, provide the registration number");
            regNo = Console.ReadLine();

            //för att kolla att regnr anges ABC123
            regNo = Vehicle.CheckRegNo(regNo);

            for (int i = 0; i < vehiclesArr.Length; i++)
            {
                if (regNo == vehiclesArr[i].RegNo)
                {
                    Console.WriteLine("The regNo already exist in the garage");

                    //gör om
                    Console.WriteLine("Please, provide the registration number in the format of ABC123");
                    regNo = Console.ReadLine();
                }
            }

            //foreach (var item in vehicles)
            //{
            //    if (regNo == item.RegNo)
            //    {
            //        Console.WriteLine("The regNo already exist in the garage");

            //        //gör om
            //        Console.WriteLine("Please, provide the registration number in the format of ABC123");
            //        regNo = Console.ReadLine();
            //    }
            //}
            Console.WriteLine("Please, provide the color of your vehicle");
            color = Console.ReadLine();
            Console.WriteLine("Please, provide the number of wheels on your vehicle");

            int.TryParse(Console.ReadLine(), out noOfWheels);

            Console.WriteLine("What kind of vehicle is it?"
                             + "\n[1]. AirPlane"
                             + "\n[2]. Boat"
                             + "\n[3]. Bus"
                             + "\n[4]. Car"
                             + "\n[5]. Motorcycle");
            vehicleType = Console.ReadLine()[0];
        }

        private char GetMenuChoise()
        {
            Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                             + "\n1. Park your vehicle in the garage"
                             + "\n2. Examine the vehicles in the garage"
                             + "\n3. Search for your vehicle"
                             + "\n4. Get your vechicle"
                             + "\n0. Exit the application");
            char menuVal;
            try
            {
                menuVal = Console.ReadLine()[0];
                return menuVal;
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {

                Console.Clear();
                Console.WriteLine("Please enter some input!");
                try
                {
                    menuVal = Console.ReadLine()[0];
                    return menuVal;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
        #endregion
    }
}