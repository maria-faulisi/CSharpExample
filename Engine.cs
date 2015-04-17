using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicleMidterm
{
    public class Engine
    {
        //member variables
        public bool IsStarted;
        //methods
        public void Start()
        {
            this.IsStarted = true;
        }

        public void Stop()
        {
            this.IsStarted = false;
        }

        //constructor
        public Engine()
        {
            this.IsStarted = false;
        }
    }
}
