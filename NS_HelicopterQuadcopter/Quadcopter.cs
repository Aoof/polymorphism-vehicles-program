// Part: 1
// Written by: Abdulrahman Mousa - 2437732

namespace NS_HelicopterQuadcopter;

public class Quadcopter : Helicopter
{
    protected int maxFlyingSpeed = 0;

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

    public override string ToString()
    {
        return base.ToString() + $", has a max flying speed of {MaxFlyingSpeed} km/h";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Quadcopter quadcopter = (Quadcopter)obj;

        return base.Equals(obj) && MaxFlyingSpeed == quadcopter.MaxFlyingSpeed;
    }
}
