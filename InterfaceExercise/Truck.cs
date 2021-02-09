using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {

        public int Year { get; set; } = 2009;
        public string Make { get; set; } = "Chevy";

        public string Model { get; set; } = "Tahoe";

        public int SpareTires { get; set; } = 1; 
        
        public bool HasTruckBed { get; set; } = true;

        public bool HasV8Engine { get; set; } = true;
        public string CompanyName { get; set; }
        public string Motto { get; set ; }
        public double EngineSize { get ; set ; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }
        string IVehicle.Year { get; set; }        
        public void ChangeGears(bool isChanged)
        {
            Console.WriteLine($"la de da dee");
        }

        public void Drive()
        {

            Console.WriteLine($"Drving in my {GetType().Name}");

        }

        public void Neutral()
        {
            Console.WriteLine($"la de da dee");
        }

        public void Park()
        {
            Console.WriteLine($"la de da dee");
        }

        public void Reverse()
        {
            Console.WriteLine($"la de da dee");
        }
    }
}
