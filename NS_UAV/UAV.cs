namespace NS_UAV;

public class UAV
{
    private double weight = 0;
    private double price = 0;

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public UAV()
    {
        Weight = 10;
        Price = 1000;
    }

    public UAV(double weight, double price)
    {
        Weight = weight;
        Price = price;
    }

    public UAV(UAV uav)
    {
        Weight = uav.Weight;
        Price = uav.Price;
    }

    public override string ToString()
    {
        return $"This {this.GetType().FullName} weighs {Weight} kg and costs {Price:C}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        UAV uav = (UAV)obj;
        double tolerance = 0.0001;
        return Math.Abs(Weight - uav.Weight) < tolerance && Math.Abs(Price - uav.Price) < tolerance;
    }
}
