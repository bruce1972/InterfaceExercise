using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany

    {
       public int Year { get; set; } = 2021;
        public string Make { get; set; } = "Cadillac";

       public string Model { get; set; } = "Escalade";

        public int SpareTires { get; set; } = 1;
        public bool HasTruckBed { get; set; } = true;

        public bool HeatedSeats { get; set; } = true;
        public string CompanyName { get; set;} 
        public string Motto { get; set; }
        public double EngineSize { get ; set ; }
        public int SeatCount { get ; set ; }
        public bool HasChangedGears { get ; set ; }
        string IVehicle.Year { get ; set ; }

        public void ChangeGears(bool isChanged)
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {

            Console.WriteLine($"Drving in my {GetType().Name}");
        }

        public void Neutral()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            Console.WriteLine("Reverse");
        }
    }
}
