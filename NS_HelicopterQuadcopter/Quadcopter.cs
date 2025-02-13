namespace NS_HelicopterQuadcopter;

public class Quadcopter : Helicopter
{
    private int maxFlyingSpeed = 0;

    public int MaxFlyingSpeed
    {
        get { return maxFlyingSpeed; }
        set { maxFlyingSpeed = value; }
    }

    public Quadcopter() : base()
    {
        MaxFlyingSpeed = 0;
    }

    public Quadcopter(string brand, double price, int horsePower, int numberOfCylinders, int creationYear, int passengerCapacity, int maxFlyingSpeed) : base(brand, price, horsePower, numberOfCylinders, creationYear, passengerCapacity)
    {
        MaxFlyingSpeed = maxFlyingSpeed;
    }

    public Quadcopter(Quadcopter quadcopter) : base(quadcopter)
    {
        MaxFlyingSpeed = quadcopter.MaxFlyingSpeed;
    }
}
