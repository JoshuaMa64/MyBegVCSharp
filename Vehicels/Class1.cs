namespace Vehicels
{
    public abstract class Vehicel { }
    public abstract class Car : Vehicel { }
    public abstract class Train : Vehicel { }

    public interface IPassengerCarrier { }
    public interface IHeavyLoadCarrier { }

    public class Suv : Car, IPassengerCarrier
    {
        public override string ToString()
        {
            return "SUV";
        }
    }
    public class PickUp : Car, IPassengerCarrier, IHeavyLoadCarrier { }
    public class Compact : Car, IPassengerCarrier { }
    public class PassengerTrain : Train, IPassengerCarrier { }
    public class FreightTrain : Train, IHeavyLoadCarrier { }
    public class T424DoubleBogey : Train, IHeavyLoadCarrier { }
}
