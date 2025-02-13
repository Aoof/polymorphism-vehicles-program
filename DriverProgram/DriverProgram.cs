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
        // Create 15 objects using various classes from the ones available in the project and keep the arguments very generic and simple
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

        // Display the objects
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
    }
}