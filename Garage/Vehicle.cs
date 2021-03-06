﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            Stats();
        }
        public virtual string Stats()
        {
            //Return Base propertise.
            return $"RegNo: {RegNo}, Color: {Color}, NoWheels: {NoOfWheels}";
        }

        public static string CheckRegNo(string regno)
        {
            if(regno.Length == 6)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (!char.IsLetter(regno[i])) return null;
                }
                for (int i = 3; i < 6; i++)
                {
                    if (!char.IsDigit(regno[i])) return null;
                }
                return regno.ToUpper();
            }
            return null;
        }

    }


    //underklass till Vehicles
    class AirPlane : Vehicle
    {
        private string model;
        private int noEngin;
        
        public AirPlane(string regNo, string color, int noOfWheels, int noEngin, string model) : base(regNo, color, noOfWheels)
        {
            this.NoEngin = noEngin;
            this.Model = model;

            Stats();
        }

        public int NoEngin
        {
            get
            {
                return this.noEngin;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Sorry, we don't accept vehicles without engines");
                }
                this.noEngin = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                //at least two caracters required
                if (value.Length < 3 )
                {
                    throw new ArgumentException("The model must contain at least two caracters");
                }
                this.model = value;

            }
        }
        public override string ToString()
        {
            return $"This is a {Model}, The regNo: {RegNo}, Color: {Color}, No of Wheels: {NoOfWheels}";
        }
        public override string Stats()
        {
            //
            return $"\n{base.Stats()} Model: {Model}, NoofEngines: {noEngin}";
        }

    }

    class Boat : Vehicle
    {
        private int cylVol;
        public Boat(string regNo, string color, int noOfWheels, int cylVol) : base(regNo, color, noOfWheels)
        {
            this.CylinderVolume = cylVol;
        }
        public override string ToString()
        {
            return $"This is a {GetType()}, The regNo: {RegNo}, Color: {Color}, No of Wheels: {NoOfWheels}, CylinderVolume: {CylinderVolume}";
        }

        public int CylinderVolume {
            get
            {
                return this.cylVol;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Sorry, cannot be 0 or negative number");
                }
                this.cylVol = value;
            }
        }
        public override string Stats()
        {
            //
            return $"\n{base.Stats()} CylinderVol: {cylVol}";
        }
    }

    class Bus : Vehicle
    {
        private int noOfSeats;
        public Bus(string regNo, string color, int noOfWheels, int noOFSeats) : base(regNo, color, noOfWheels)
        {
            this.NoOfSeats = noOFSeats;
        }
        public override string ToString()
        {
            return $"This is a {GetType()}, The regNo: {RegNo}, Color: {Color}, No of Wheels: {NoOfWheels}, Number of seats: {NoOfSeats}";
        }
        public int NoOfSeats
        {
            get
            {
                return this.noOfSeats;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Sorry, cannot be 0 or negative number");
                }
                this.noOfSeats = value;
            }
        }
        public override string Stats()
        {
            //
            return $"\n{base.Stats()} number of seats: {noOfSeats}";
        }
    }
    class Car : Vehicle
    {
        private int hrsPwr;
        public Car(string regNo, string color, int noOfWheels, int hrsPwr) : base(regNo, color, noOfWheels)
        {

        }
        public override string ToString()
        {
            return $"This is a {GetType()}, The regNo: {RegNo}, Color: {Color}, No of Wheels: {NoOfWheels}, HorsePower: {HrsPwr}";
        }

        public int HrsPwr
        {
            get
            {
                return this.hrsPwr;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Sorry, cannot be 0 or negative number - WHAT KIND OF A CAR ARE YOU DRIVING...???");
                }
                this.hrsPwr = value;
            }
        }
        public override string Stats()
        {
            //
            return $"\n{base.Stats()} HorsePower: {hrsPwr}";
        }
    }
    class Motorcycle : Vehicle
    {
        private int hrsPwr;
        public Motorcycle(string regNo, string color, int noOfWheels, int hrsPwr) : base(regNo, color, noOfWheels)
        {
        }
        public override string ToString()
        {
            return $"This is a {GetType()}, The regNo: {RegNo}, Color: {Color}, No of Wheels: {NoOfWheels}, HorsePower: {HrsPwr}";
        }
        public int HrsPwr
        {
            get
            {
                return this.hrsPwr;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Sorry, cannot be 0 or negative number");
                }
                this.hrsPwr = value;
            }
        }
        public override string Stats()
        {
            //
            return $"\n{base.Stats()} HorsePower: {hrsPwr}";
        }

    }

}
