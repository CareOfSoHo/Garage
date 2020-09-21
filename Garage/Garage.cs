using System;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;
using System.Linq;

namespace Garage
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] vehiclesArr;

        protected int buff; // buffert
        protected T[] vehicleArray;
        protected int noOfSpaces; // tillgängliga platser
        protected int noUsedSpaces; // tagna platser

        public string RegNo { get; set; }

        public Garage()
        {
            buff = 10;
            noUsedSpaces = 0; // garaget är tomt
            noOfSpaces = 30; // tillgängliga platser 3st, ToDo: dynamisk
            vehicleArray = new T[noOfSpaces];
            
            //vehiclesArr = new Vehicle[noOfSpaces];
            //vehiclesArr[4] = { RegNo = "ABC234", Color = "Black", NoOfWheels = 4, HrsPwr = 300 } as Car;
            //vehiclesArr[4] = new Car { RegNo = "ABC234", Color = "Black", NoOfWheels = 4, HrsPwr = 300 } ;
            //
            // vehicleArray = new Car { "ABC234", "Black", 4 };
            //vehicleArray = new Car { regNo = "ABC234", Color = "Black", NoOfWheels = 4 };
            //string[] vehicleTest =new Car{RegNo = "ABC234",Color= "Black", NoOfWheels=4 };

        }

        public bool AddV(T vehicle)
        {
            //kolla plats kvar

            // om nu.ll return false
            //kolla index, för att lägga rätt i arrayen
            vehicleArray[0] = vehicle;
            return true;

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
            if (compareVehicle != null && this.RegNo == compareVehicle.RegNo)
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

        public IEnumerator<T> GetEnumerator()
        {
            //iterera arrayen och returnera vehicle
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void RetriveVehicles()
        {
            vehiclesArr = new Vehicle[4]
            {
                new AirPlane("SAS987", "Grey", 16, 4, "AirBus") as Vehicle,
                new AirPlane("AIR643", "Gold", 30, 8, "727") as Vehicle,
                new Boat("kak234", "Blue", 0, 35) as Vehicle,
                new Boat("sos124", "white", 0, 305) as Vehicle
            };

            foreach (var item in vehiclesArr)
            {
                Console.WriteLine(item.GetType().ToString() + " Color: " + item.Color + "RegNo: " + item.RegNo);
            }
            return;
        }
    }
}
