using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Ari";
            taxi.OnDuty = true;
            taxi.NumPassenger = 4;

            taxi.TaxiInfo();
            {
                if (taxi.OnDuty == true)
                {
                    taxi.PickUpPassenger();
                }
                else
                {
                    taxi.DropOffPassenger();
                }
            }

            Console.ReadKey();
        }
    }
}
