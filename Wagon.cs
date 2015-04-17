using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicleMidterm
{
    public class Wagon : Car
    {
        //member variables

        //methods

        //constructor
        public Wagon()
        {
            this.TheEngine.IsStarted = false;
            this.NumDoors = 5;
            this.NumWheels = 4;
            this.TopSpeed = 5;
        }
    }
}
