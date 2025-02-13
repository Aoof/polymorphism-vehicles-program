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

    public override string ToString()
    {
        return base.ToString() + $", has {NumberOfRotors} rotors";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Multirotor multirotor = (Multirotor)obj;

        return base.Equals(obj) && NumberOfRotors == multirotor.NumberOfRotors;
    }
}
