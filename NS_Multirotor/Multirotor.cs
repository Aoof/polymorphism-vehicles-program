namespace NS_Multirotor;

using NS_HelicopterQuadcopter;

public class Multirotor : Helicopter
{
    private int numberOfRotors;

    public int NumberOfRotors
    {
        get { return numberOfRotors; }
        set { numberOfRotors = value; }
    }

    public Multirotor() : base()
    {
        NumberOfRotors = 0;
    }

    public Multirotor(string brand, double price, int horsePower, int numberOfCylinders, int creationYear, int passengerCapacity, int numberOfRotors) : base(brand, price, horsePower, numberOfCylinders, creationYear, passengerCapacity)
    {
        NumberOfRotors = numberOfRotors;
    }

    public Multirotor(Multirotor multirotor) : base(multirotor)
    {
        NumberOfRotors = multirotor.NumberOfRotors;
    }
}
