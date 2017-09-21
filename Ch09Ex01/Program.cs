using static System.Console;
using Vehicels;

namespace Ch09Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new PassengerTrain());
            AddPassenger(new PickUp());
            AddPassenger(new Suv());
            ReadKey();
        }

        private static void AddPassenger(IPassengerCarrier vehicle)
        {
            WriteLine(vehicle.ToString());
        }
    }
}
