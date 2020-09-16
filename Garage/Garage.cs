using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;

namespace Garage
{
    public class Garage<T> where T : Vehicle
    {
        protected int buff; // buffert
        protected T[] vehicleArray;
        protected int noOfSpaces; // tillgängliga platser
        protected int noUsedSpaces; // tagna platser

        public string RegNo { get; set; }
       
        public Garage()
        {
            buff = 3;
            noUsedSpaces = 0; // garaget är tomt
            noOfSpaces = 3; // tillgängliga platser 3st, ToDo: dynamisk
            vehicleArray = new T[noOfSpaces];
           
        }

        #region Properties
        public int NoOfSpaces 
        { 
            get
            {
                return noOfSpaces;
            }
        }

        public T this[int index]
        {
            get 
            {
                return vehicleArray[index];
            }
        }

        #endregion



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

        public void AddVehicle(T regNo)
        {
            vehicleArray[noOfSpaces++] = regNo;
            
        }

        //public List<Vehicle> Retrive()
        //{
        //    vehicles = new List<Vehicle>();
        //    vehicles.Add(new Vehicle() { RegNo = "FZK 678", Color = "Black", NoOfWheels = 4 });
        //}
    }
}
