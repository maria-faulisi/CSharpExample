using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicleMidterm
{
    class Program
    {
        static void Main(string[] args)
        {

            Car fast = new Car();
            Console.WriteLine(fast.About());

            Wagon slower = new Wagon();
            Console.WriteLine(slower.About());

            CompactCar evenSlower = new CompactCar();
            Console.WriteLine(evenSlower.About());

            ToyCar forKids = new ToyCar();
            Console.WriteLine(forKids.About());
            forKids.WindUp();
            Console.WriteLine(forKids.About());

            MotorCycle vroom = new MotorCycle();
            Console.WriteLine(vroom.About());

            Console.WriteLine(fast.Race(fast, evenSlower));
            Console.WriteLine(fast.Race(fast, slower));
            Console.WriteLine(fast.Race(fast, vroom));
            Console.WriteLine(fast.Race(fast, forKids));
            

            Console.ReadKey();
        }
    }
}
