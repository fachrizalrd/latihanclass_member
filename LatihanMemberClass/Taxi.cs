using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        //properties
        public string DriverName { set; get; }
        public bool OnDuty { set; get; }
        public int NumPassenger { set; get; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty ? "Yes" : "No");
            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);

        }

        public void PickUpPassenger()
        {
            Console.WriteLine("Driver {0} is busy", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("Driver {0} available", DriverName);
        }
    }
}
