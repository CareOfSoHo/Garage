using System;
namespace Garage
{
    public abstract class Vehicle
    {
        public string RegNo { get; set; }
        public string Color { get; set; }
        public int NoOfWheels { get; set; }

        public Vehicle(string regNo, string color, int noOfWheels)
        {
            this.RegNo = regNo;
            this.Color = color;
            this.NoOfWheels = noOfWheels;
        }

    }


    //underklass till Vehicles
    class AirPlane : Vehicle
    {
        int NumberofEngines = 1;
        string Model = "Black Hawk";
        public AirPlane(string regNo, string color, int noOfWheels) : base(regNo, color, noOfWheels)
        {
        }
        public override string ToString()
        {
            return $"This is a {this.Model}, The regNo: {this.RegNo}, Color: {this.Color}, No of Wheels: {this.NoOfWheels}, No of engines: {this.NumberofEngines}";
        }

        //public override string Stats()
        //{
        //    //Här anropas superklassens metod, hämtar egenskaperna i string-format och konkatenerar med hästens color-egenskap.
        //    return $"\n{base.Stats()} Color: {this.Color}";
        //}
        //public override void DoSound()
        //{
        //    //Exempel på implementering
        //    Console.WriteLine("IHahahah");
        //}
    }

    class Boat : Vehicle
    {
        string CylinderVolume = "30mm";
        public Boat(string regNo, string color, int noOfWheels) : base(regNo, color, noOfWheels)
        {
        }
        public override string ToString()
        {
            return $"The regNo: {this.RegNo}, Color: {this.Color}, No of Wheels: {this.NoOfWheels}, CylinderVolume: {this.CylinderVolume}";
        }

    }

    class Bus : Vehicle
    {
        int NoOfSeats = 67;
        public Bus(string regNo, string color, int noOfWheels) : base(regNo, color, noOfWheels)
        {
        }
        public override string ToString()
        {
            return $"The regNo: {this.RegNo}, Color: {this.Color}, No of Wheels: {this.NoOfWheels}, Number of seats: {this.NoOfSeats}";
        }

    }
    class Car : Vehicle
    {
        int hrsPwr = 1700;
        public Car(string regNo, string color, int noOfWheels) : base(regNo, color, noOfWheels)
        {

        }
        public override string ToString()
        {
            return $"The regNo: {this.RegNo}, Color: {this.Color}, No of Wheels: {this.NoOfWheels}, HorsePower: {this.hrsPwr}";
        }

    }
    class Motorcycle : Vehicle
    {
        int hrsPwr = 1200;
        public Motorcycle(string regNo, string color, int noOfWheels) : base(regNo, color, noOfWheels)
        {
        }
        public override string ToString()
        {
            return $"The regNo: {this.RegNo}, Color: {this.Color}, No of Wheels: {this.NoOfWheels}, HorsePower: {this.hrsPwr}";
        }

    }

}
