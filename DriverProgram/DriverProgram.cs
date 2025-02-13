// Part: 1
// Written by: Abdulrahman Mousa - 2437732

using NS_Airplane;
using NS_Agricultural_MAV;
using NS_UAV;
using NS_HelicopterQuadcopter;
using NS_Multirotor;

namespace DriverProgram;
static class DriverProgram
{
    static void Main(string[] args)
    {
        // By providing the UML diagram to an AI it generated the following 15 objects
        Airplane airplane = new Airplane("Boeing", 1000000, 1000);
        Multirotor multirotor = new Multirotor("DJI", 1000, 100, 4, 2021, 2, 4);
        Helicopter helicopter = new Helicopter("Bell", 1000000, 1000, 6, 2021, 6);
        UAV uav = new UAV(100, 1000);
        AgriculturalDrone agriculturalDrone = new AgriculturalDrone(100, 1000, "DJI", 1);
        MAV mav = new MAV(100, 1000, "DJI", 2);
        Airplane airplane2 = new Airplane(airplane);
        Multirotor multirotor2 = new Multirotor(multirotor);
        Helicopter helicopter2 = new Helicopter(helicopter);
        UAV uav2 = new UAV(uav);
        AgriculturalDrone agriculturalDrone2 = new AgriculturalDrone(agriculturalDrone);
        MAV mav2 = new MAV(mav);
        Airplane airplane3 = new Airplane();
        Multirotor multirotor3 = new Multirotor();
        Helicopter helicopter3 = new Helicopter();
        UAV uav3 = new UAV();
        AgriculturalDrone agriculturalDrone3 = new AgriculturalDrone();
        MAV mav3 = new MAV();

        Console.WriteLine("Testing the classes ToString() functions:");
        Console.WriteLine(airplane);
        Console.WriteLine(multirotor);
        Console.WriteLine(helicopter);
        Console.WriteLine(uav);
        Console.WriteLine(agriculturalDrone);
        Console.WriteLine(mav);
        Console.WriteLine(airplane2);
        Console.WriteLine(multirotor2);
        Console.WriteLine(helicopter2);
        Console.WriteLine(uav2);
        Console.WriteLine(agriculturalDrone2);
        Console.WriteLine(mav2);
        Console.WriteLine(airplane3);
        Console.WriteLine(multirotor3);
        Console.WriteLine(helicopter3);
        Console.WriteLine(uav3);
        Console.WriteLine(agriculturalDrone3);
        Console.WriteLine(mav3);
    
        Console.WriteLine("airplane == multirotor: " + airplane.Equals(multirotor));
        Console.WriteLine("multirotor == helicopter: " + multirotor.Equals(helicopter));
        Console.WriteLine("helicopter == uav: " + helicopter.Equals(uav));
        Console.WriteLine("uav == agriculturalDrone: " + uav.Equals(agriculturalDrone));
        Console.WriteLine("airplane1 == airplane2: " + airplane.Equals(airplane2));

        object[] flyingObjects = {
            helicopter, multirotor, airplane,
            uav, agriculturalDrone,
            mav, helicopter2, multirotor2,
            airplane2, uav2,
            agriculturalDrone2, mav2,
            helicopter3, multirotor3, airplane3
        };

        object[] flyingObjectsWithoutUAV = {
            new Airplane("Boeing", 1000000, 1000),
            new Multirotor("DJI", 1000, 100, 4, 2021, 2, 4),
            new Helicopter("Bell", 1000000, 1000, 6, 2021, 6),
            new Airplane(airplane),
            new Multirotor(multirotor),
            new Helicopter(helicopter),
            new Airplane(),
            new Multirotor(),
            new Helicopter(),
            new Airplane(airplane),
            new Multirotor(multirotor),
            new Helicopter(helicopter),
            new Airplane(),
            new Multirotor(),
            new Helicopter()
        };

        Console.WriteLine($"\nFinding the least and most expensive UAVs in the array `flyingObjects`:");
        FindLeastAndMostExpensiveUAV(flyingObjects);

        Console.WriteLine($"\nFinding the least and most expensive UAVs in the array `flyingObjects`:");
        FindLeastAndMostExpensiveUAV(flyingObjectsWithoutUAV);
    }

    static void FindLeastAndMostExpensiveUAV(object[] flyingObjects)
    {
        double minPrice = double.MaxValue;
        double maxPrice = double.MinValue;
        UAV? minPriceUAV = null;
        UAV? maxPriceUAV = null;

        foreach (object obj in flyingObjects)
        {
            if (obj.GetType() == typeof(UAV))
            {
                UAV uav = (UAV)obj;
                if (uav.Price < minPrice)
                {
                    minPrice = uav.Price;
                    minPriceUAV = uav;
                }

                if (uav.Price > maxPrice)
                {
                    maxPrice = uav.Price;
                    maxPriceUAV = uav;
                }
            }
        }

        if (minPriceUAV == null || maxPriceUAV == null)
        {
            Console.WriteLine("No UAVs found in the array");
            return;
        }

        Console.WriteLine($"The least expensive UAV is: {minPriceUAV}");
        Console.WriteLine($"The most expensive UAV is: {maxPriceUAV}");
    }
}