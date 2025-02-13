// Part: 1
// Written by: Abdulrahman Mousa - 2437732

namespace NS_Agricultural_MAV;

using NS_UAV;

public class MAV : UAV
{
    protected string brand = "";
    protected int carryCapacity = 0;

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

    public override string ToString()
    {
        return base.ToString() + $", is a {this.GetType().FullName} manufactured by {Brand}, and can carry {CarryCapacity} kg";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        MAV mav = (MAV)obj;
        return base.Equals(obj) && Brand == mav.Brand && CarryCapacity == mav.CarryCapacity;
    }
}
