// Part: 2
// Written by: Abdulrahman Mousa - 2437732

namespace DriverProgram_Part2;

using NS_Airplane;
using NS_Multirotor;
using NS_HelicopterQuadcopter;
using NS_UAV;
using NS_Agricultural_MAV;

static public class DriverProgram
{
    static void Main(string[] args)
    {
        object[] flyingObjects = {
            new Airplane("BogusAirplane", 500000, 800),
            new Multirotor("BogusMultirotor", 300000, 600, 4, 2005, 4, 6),
            new Helicopter("BogusHelicopter", 800000, 1200, 6, 1995, 5),
            new UAV(75, 750),
            new AgriculturalDrone(75, 750, "BogusModel", 2.5),
            new MAV(75, 750, "BogusMAV", 3),
            new Airplane("BogusAirplane2", 600000, 850),
            new Multirotor("BogusMultirotor2", 310000, 620, 4, 2006, 4, 6),
            new Helicopter("BogusHelicopter2", 810000, 1250, 6, 1996, 5),
            new UAV(80, 800),
            new AgriculturalDrone(80, 800, "BogusModel2", 2.8),
            new MAV(80, 800, "BogusMAV2", 3),
            new Airplane("BogusAirplane3", 520000, 810),
            new Multirotor("BogusMultirotor3", 305000, 610, 4, 2007, 4, 6),
            new Helicopter("BogusHelicopter3", 820000, 1260, 6, 1997, 5)
        };

        object[] copiedObjects = CopyFlyingObjects(flyingObjects);

        Console.WriteLine("\nOriginal Objects:");
        for (int i = 0; i < flyingObjects.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + flyingObjects[i]);
        }

        Console.WriteLine("\n\nCopied Objects:");
        for (int i = 0; i < copiedObjects.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + copiedObjects[i]);
        }
    }

    static object[] CopyFlyingObjects(object[] flyingObjects)
    {
        object[] copiedObjects = new object[flyingObjects.Length];
        for (int i = 0; i < flyingObjects.Length; i++)
        {
            object obj = flyingObjects[i];
            if (obj.GetType() == typeof(Airplane))
            {
                copiedObjects[i] = new Airplane((Airplane)obj);
            }
            else if (obj.GetType() == typeof(Multirotor))
            {
                copiedObjects[i] = new Multirotor((Multirotor)obj);
            }
            else if (obj.GetType() == typeof(Helicopter))
            {
                copiedObjects[i] = new Helicopter((Helicopter)obj);
            }
            else if (obj.GetType() == typeof(UAV))
            {
                copiedObjects[i] = new UAV((UAV)obj);
            }
            else if (obj.GetType() == typeof(AgriculturalDrone))
            {
                copiedObjects[i] = new AgriculturalDrone((AgriculturalDrone)obj);
            }
            else if (obj.GetType() == typeof(MAV))
            {
                copiedObjects[i] = new MAV((MAV)obj);
            }
        }

        return copiedObjects;
    }
}
