using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicleMidterm
{
    public class MotorCycle : MotorVehicle
    {
        //member variables

        //methods

        //constructor
        public MotorCycle()
        {
            this.TheEngine.IsStarted = false;
            this.NumWheels = 2;
            this.NumDoors = 0;
            this.TopSpeed = 7;
        }
    }
}
