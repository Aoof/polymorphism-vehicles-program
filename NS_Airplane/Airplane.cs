namespace NS_Airplane;

public class Airplane
{
    private string brand = "";
    private double price = 0.0;
    private int horsePower = 0;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int HorsePower
    {
        get { return horsePower; }
        set { horsePower = value; }
    }

    public Airplane()
    {
        Brand = "Unknown";
        Price = 0.0;
        HorsePower = 0;
    }

    public Airplane(string brand, double price, int horsePower)
    {
        Brand = brand;
        Price = price;
        HorsePower = horsePower;
    }

    public Airplane(Airplane airplane)
    {
        Brand = airplane.Brand;
        Price = airplane.Price;
        HorsePower = airplane.HorsePower;
    }
}
