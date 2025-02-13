namespace NS_HelicopterQuadcopter;

using NS_Airplane;

public class Helicopter : Airplane
{
    private int numberOfCylinders;
    private int creationYear;
    private int passengerCapacity;

    public int NumberOfCylinders
    {
        get { return numberOfCylinders; }
        set { numberOfCylinders = value; }
    }

    public int CreationYear
    {
        get { return creationYear; }
        set { creationYear = value; }
    }

    public int PassengerCapacity
    {
        get { return passengerCapacity; }
        set { passengerCapacity = value; }
    }

    public Helicopter() : base()
    {
        NumberOfCylinders = 0;
        CreationYear = 0;
        PassengerCapacity = 0;
    }

    public Helicopter(string brand, double price, int horsePower, int numberOfCylinders, int creationYear, int passengerCapacity) : base(brand, price, horsePower)
    {
        NumberOfCylinders = numberOfCylinders;
        CreationYear = creationYear;
        PassengerCapacity = passengerCapacity;
    }

    public Helicopter(Helicopter helicopter) : base(helicopter)
    {
        NumberOfCylinders = helicopter.NumberOfCylinders;
        CreationYear = helicopter.CreationYear;
        PassengerCapacity = helicopter.PassengerCapacity;
    }

    public override string ToString()
    {
        return base.ToString() + $", has {NumberOfCylinders} cylinders, was created in {CreationYear}, and can carry {PassengerCapacity} passengers";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Helicopter helicopter = (Helicopter)obj;

        return base.Equals(obj) && NumberOfCylinders == helicopter.NumberOfCylinders && CreationYear == helicopter.CreationYear && PassengerCapacity == helicopter.PassengerCapacity;
    }
}