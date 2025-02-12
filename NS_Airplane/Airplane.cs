namespace NS_Airplane;

public class Airplane
{
    private string brand;
    private double price;
    private int horsePower;

    public Airplane()
    {
        this.brand = "Unknown";
        this.price = 0;
        this.horsePower = 0;
    }

    public Airplane(string brand, double price, int horsePower)
    {
        this.brand = brand;
        this.price = price;
        this.horsePower = horsePower;
    }

    public Airplane(Airplane airplane)
    {
        this.brand = airplane.brand;
        this.price = airplane.price;
        this.horsePower = airplane.horsePower;
    }

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
}
