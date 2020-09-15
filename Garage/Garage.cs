using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Garage
{
    public class Garage<T>
    {
        private List<Vehicle> vehicles;
        public string RegNo { get; set; }
       
        public Garage()
        {
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Vehicle compareVehicle = obj as Vehicle;
            if(compareVehicle != null && this.RegNo == compareVehicle.RegNo)
            {
                return true;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //public Vehicle GetVehicle(string regNo)
        //{
        //    Vehicle vehicle; // = new Vehicle(string regNo, string color, int noOfWheels);
        //    if(regNo=="FZK678")
        //    {
        //       // vehicle.RegNo = regNo;
        //        //vehicle.Color = Color;

        //    }
        //    return; // vehicle;
        //}

        //public List<Vehicle> Retrive()
        //{
        //    vehicles = new List<Vehicle>();
        //    vehicles.Add(new Vehicle() { RegNo = "FZK 678", Color = "Black", NoOfWheels = 4 });
        //}
    }
}
