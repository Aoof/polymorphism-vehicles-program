namespace NS_Agricultural_MAV;

using NS_UAV;

public class MAV : UAV
{
    private string brand = "";
    private int carryCapacity = 0;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public int CarryCapacity
    {
        get { return carryCapacity; }
        set { carryCapacity = value; }
    }

    public MAV() : base()
    {
        Brand = "Unknown";
        CarryCapacity = 2;
    }

    public MAV(double weight, double price, string brand, int carryCapacity) : base(weight, price)
    {
        Brand = brand;
        CarryCapacity = carryCapacity;
    }

    public MAV(MAV mav) : base(mav)
    {
        Brand = mav.Brand;
        CarryCapacity = mav.CarryCapacity;
    }
}
