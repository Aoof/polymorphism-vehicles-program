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
    class Airplane {
        - string brand
        - double price
        - int horsePower
        + Airplane()
        + Airplane(string, double, int)
        + Airplane(Airplane)
    }

    class Helicopter {
        - int numberOfCylinders
        - int creationYear
        - int passengerCapacity
        + Helicopter()
        + Helicopter(string, double, int, int, int, int)
        + Helicopter(Helicopter)
    }
    Airplane <|-- Helicopter

    class Quadcopter {
        - int maxFlyingSpeed
        + Quadcopter()
        + Quadcopter(string, double, int, int, int, int, int)
        + Quadcopter(Quadcopter)
    }
    Helicopter <|-- Quadcopter

    class Multirotor {
        - int numberOfRotors
        + Multirotor()
        + Multirotor(string, double, int, int, int, int, int)
        + Multirotor(Multirotor)
    }
    Helicopter <|-- Multirotor

    class UAV {
        - double weight
        - double price
        + UAV()
        + UAV(double, double)
        + UAV(UAV)
    }

    class MAV {
        - string brand
        - int carryCapacity
        + MAV()
        + MAV(double, double, string, int)
        + MAV(MAV)
    }
    UAV <|-- MAV

    class AgriculturalDrone {
        - string model
        - double size
        + AgriculturalDrone()
        + AgriculturalDrone(double, double, string, double)
        + AgriculturalDrone(AgriculturalDrone)
    }
    UAV <|-- AgriculturalDrone
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