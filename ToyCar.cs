using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicleMidterm
{
    public class ToyCar : Car
    {
        //member variables
        public bool IsWoundUp;

        //methods
        public void WindUp()
        {
            this.IsWoundUp = true;
            this.TopSpeed = 4;
        }

        //constructor
        public ToyCar()
        {
            this.IsWoundUp = false;
            this.NumDoors = 0;
            this.NumWheels = 4;
            this.TopSpeed = 0;
        }
    }
}
