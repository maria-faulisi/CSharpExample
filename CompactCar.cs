using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicleMidterm
{
    public class CompactCar : Car
    {
        //member variables

        //methods

        //constructor
        public CompactCar()
        {
            this.TheEngine.IsStarted = false;
            this.NumDoors = 2;
            this.NumWheels = 4;
            this.TopSpeed = 3;
        }
    }
}
