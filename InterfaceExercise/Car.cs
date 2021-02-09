using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car:  IVehicle, ICompany

    {
        public int Year { get; set; } = 2020;
        public string Make { get; set; } = "Chevrolet";

        public string Model { get; set; } = "Camaro";

        public int SpareTires { get; set; } = 1;
        public bool HasTrunk { get; set; } = true;

        public bool StickShift { get; set; } = true;
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public double EngineSize { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }
        string IVehicle.Year { get ; set; }

        public void ChangeGears(bool isChanged)
        {
          
        }

        public void Drive()
        {
            Console.WriteLine($"Drive in my{GetType().Name}");

        }

        public void Neutral()
        {
           
        }

        public void Park()
        {
           
        }

        public void Reverse()
        {


        }
    }

}
