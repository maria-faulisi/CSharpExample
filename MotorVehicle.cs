using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicleMidterm
{
    public abstract class MotorVehicle
    {
        //member variables
        public Engine TheEngine;
        protected int NumDoors;
        protected int NumWheels;
        public int TopSpeed;
        static int NumRacesRun;

        //methods
        public virtual string About()
        {
            string s = "";
            s += string.Format("{0} has {1} doors.", this, this.NumDoors);
            s += string.Format("\n{0} has {1} wheels.", this, this.NumWheels);
            s += string.Format("\nIt's TopSpeed is {0}", this.TopSpeed);
            return s;
        }

        public string Race(MotorVehicle a, MotorVehicle b)
        {
            NumRacesRun++;
            string s = "";
            s += string.Format("\nRace {0}", NumRacesRun);

            if (a.TopSpeed > b.TopSpeed)
            {
                s += string.Format("\n{0} wins", a);
            }
            else
                s += string.Format("\n{0} wins", b);
            return s;
        }

        public void StartEngine()
        {
            TheEngine.IsStarted = true;
        }

        public void StopEngine()
        {
            TheEngine.IsStarted = false;
        }

        //constructor
        public MotorVehicle()
        {
            this.TheEngine = new Engine();
            this.NumDoors = 4;
            this.NumWheels = 4;
            this.TopSpeed = 10;

        }
    }
}
