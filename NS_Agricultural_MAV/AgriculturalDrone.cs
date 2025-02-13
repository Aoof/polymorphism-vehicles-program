// Part: 1
// Written by: Abdulrahman Mousa - 2437732

namespace NS_Agricultural_MAV;

using NS_UAV;

public class AgriculturalDrone : UAV
{
    protected string model = "";
    protected double size = 0;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public double Size
    {
        get { return size; }
        set { size = value; }
    }

    public AgriculturalDrone() : base()
    {
        Model = "An Unknown Model";
        Size = 1;
    }

    public AgriculturalDrone(double weight, double price, string model, double size) : base(weight, price)
    {
        Model = model;
        Size = size;
    }

    public AgriculturalDrone(AgriculturalDrone agriculturalDrone) : base(agriculturalDrone)
    {
        Model = agriculturalDrone.Model;
        Size = agriculturalDrone.Size;
    }

    public override string ToString()
    {
        return base.ToString() + $", is a {this.GetType().Name} model {Model}, and has a size of {Size} m²";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        AgriculturalDrone agriculturalDrone = (AgriculturalDrone)obj;
        double tolerance = 0.0001;
        return base.Equals(obj) && Model == agriculturalDrone.Model && Math.Abs(Size - agriculturalDrone.Size) < tolerance;
    }
}
