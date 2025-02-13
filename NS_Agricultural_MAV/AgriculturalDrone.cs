namespace NS_Agricultural_MAV;

using NS_UAV;

public class AgriculturalDrone : UAV
{
    private string model = "";
    private double size = 0;

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
        Model = "Unknown";
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
}
