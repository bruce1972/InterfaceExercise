namespace InterfaceExercise
{
    interface ITruck
    {
        bool HasTruckBed { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }

        void Drive();
    }
}