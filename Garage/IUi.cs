using System;

namespace Garage
{
    internal interface IUi
    {


        public void Menu()
        {
            while (true)
            {
                char choise = GetMenuChoise();
                switch (choise)
                {
                    case '1':
                        //ParkVehicle();
                        break;
                    case '2':
                        //ListAllVehicles();
                        break;
                    case '3':
                        //SearchVehicle();
                        break;
                    case '4':
                       // GetVehicle();
                        break;
                    case '0':
                        //Environment.Exit(0);
                        break;
                    default:
                        //Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
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

    }
}