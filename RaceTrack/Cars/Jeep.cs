using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    class Jeep : RaceCar
    {
        public Jeep()
        {
            Name = "Jeep Wrangler Rubicon";
            TopSpeed = 80;
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} drives over all of the other cars at the finish line!");
            base.Brake();
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} puts it in 4 wheel drive!");
        }
    }
}
