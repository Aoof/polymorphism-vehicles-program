# Polymorphism Vehicles Program

## Overview
This solution demonstrates polymorphism within a vehicle context. The project is split into several sub-projects:
- **DriverProgram**: Contains the main entry point.
- **NS_Airplane**: Defines the base Airplane class.
- **NS_HelicopterQuadcopter**: Contains Helicopter, Quadcopter classes.
- **NS_Multirotor**: Contains the Multirotor class (inherits from Helicopter).
- **NS_UAV**: Defines the base UAV class.
- **NS_Agricultural_MAV**: Contains MAV and AgriculturalDrone classes (inherit from UAV).

## Structure
- The solution file (.sln) is at the project root.
- Each project is contained within its respective folder.

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
3. The application will display a "Hello World!" message as a basic proof-of-concept.