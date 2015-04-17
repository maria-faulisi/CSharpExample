using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicleMidterm
{
    public class Car : MotorVehicle
    {
        //member variables


        //methods

        //constructor
        public Car()
        {
            this.TheEngine.IsStarted = false;
            this.NumDoors = 4;
            this.NumWheels = 4;
            this.TopSpeed = 10;
        }
    }
}
