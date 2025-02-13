# Polymorphism Vehicles Program

## Overview
This program demonstrates polymorphism with various vehicle types. The file structure is organized to highlight inheritance and method overriding.

## Part 1 Reflection
#### **The method `FindLeastAndMostExpensiveUAV()` in the [DriverProgram](./DriverProgram/DriverProgram.cs) has accurate results because we do the following.**
- Accepts an array of any flying objects.
- Goes through them and checks the type of each object.
- Once it finds a UAV object it compares the price with the current least and most expensive UAVs. (The reason why the result is accurate if the array contained any UAV object)
- If the current minimum or maximum UAV is null, it will result in "No UAVs found" as expected.

## Part 2 Reflection
#### **The method `CopyFlyingObjects()` in the [DriverProgram_Part2](./DriverProgram_Part2/DriverProgram_Part2.cs) has accurate results because we do the following.**
- Accepts an array of any flying objects. `object[]`
- Goes through them and checks the type of each object.
- Utilizes the copy constructor to create a new object of the same type.
- Adds the new object to a new array.
- Returns the new array of copied objects.

## File Structure
- **DriverProgram**: Contains the main entry point and helper methods.
- **NS_Airplane**: Defines the base Airplane class with properties such as Brand, Price, and HorsePower.
- **NS_HelicopterQuadcopter**: 
  - Contains Helicopter (inherits from Airplane) with additional properties: NumberOfCylinders, CreationYear, and PassengerCapacity.
  - Contains Quadcopter (inherits from Helicopter) with an extra property: MaxFlyingSpeed.
- **NS_Multirotor**: Contains the Multirotor class (inherits from Helicopter) with the additional property NumberOfRotors.
- **NS_UAV**: Defines the base UAV class with properties Weight and Price.
- **NS_Agricultural_MAV**: 
  - Contains MAV (inherits from UAV) with extra properties: Brand and CarryCapacity.
  - Contains AgriculturalDrone (inherits from UAV) with additional properties: Model and Size.

## UML Diagram
Below is a Mermaid UML diagram representing the structure:

```mermaid
classDiagram
  NS_Airplane.Airplane <|-- NS_HelicopterQuadcopter.Helicopter
  NS_HelicopterQuadcopter.Helicopter <|-- NS_HelicopterQuadcopter.Quadcopter
  NS_HelicopterQuadcopter.Helicopter <|-- NS_Multirotor.Multirotor
  NS_UAV.UAV <|-- NS_Agricultural_MAV.MAV
  NS_UAV.UAV <|-- NS_Agricultural_MAV.AgriculturalDrone

  class NS_Airplane.Airplane {
    - string brand
    - double price
    - int horsePower
    + Airplane()
    + Airplane(string, double, int)
    + Airplane(Airplane)
  }

  class NS_HelicopterQuadcopter.Helicopter {
    - int numberOfCylinders
    - int creationYear
    - int passengerCapacity
    + Helicopter()
    + Helicopter(string, double, int, int, int, int)
    + Helicopter(Helicopter)
  }

  class NS_HelicopterQuadcopter.Quadcopter {
    - int maxFlyingSpeed
    + Quadcopter()
    + Quadcopter(string, double, int, int, int, int, int)
    + Quadcopter(Quadcopter)
  }

  class NS_Multirotor.Multirotor {
    - int numberOfRotors
    + Multirotor()
    + Multirotor(string, double, int, int, int, int, int)
    + Multirotor(Multirotor)
  }

  class NS_UAV.UAV {
    - double weight
    - double price
    + UAV()
    + UAV(double, double)
    + UAV(UAV)
  }

  class NS_Agricultural_MAV.MAV {
    - string brand
    - int carryCapacity
    + MAV()
    + MAV(double, double, string, int)
    + MAV(MAV)
  }

  class NS_Agricultural_MAV.AgriculturalDrone {
    - string model
    - double size
    + AgriculturalDrone()
    + AgriculturalDrone(double, double, string, double)
    + AgriculturalDrone(AgriculturalDrone)
  }
```

## Running the Application
1. Open the solution in Visual Studio or your preferred IDE.
2. Alternatively, run the application from the command line:
   - Navigate to the solution directory.
   - Execute:
     ```bash
     dotnet run --project DriverProgram
     ```
3. The application creates various vehicle objects and demonstrates the use of overridden methods and polymorphism.