using System.Collections.Generic;

namespace Garage.GeneralLogic
{
    public class Factory:Vehicle
    {
        public Factory()
        {

        }
        public static List<Tire> TireList = new List<Tire>();

        public static void CreateParts()
        {
            
            //Tire Types:
            Tire tireA = new Tire("Michelin", 34,1);
            Tire tireB = new Tire("Pirelli", 34,2);
            Tire tireC = new Tire("Dunlop", 34,3);
            Tire tireD = new Tire("GoodYear", 34,4);
            Tire tireE = new Tire("Kumho", 34,5);
            Tire tireF = new Tire("Hankook", 34,6);

           TireList.Add(tireA);
           TireList.Add(tireB);
           TireList.Add(tireC);
           TireList.Add(tireD);
           TireList.Add(tireE);
           TireList.Add(tireF);
        }

        //assemblieng fuel vehicles:
        public static Vehicle FuelAssemblyLine(Engine Engine_type,string License_plate,string owner_name,string owner_phone,string model,float amountOfGas,VehicleType Vehicle_type, int typeOfTires, LicenseType type, int EngineCapacity, bool IsCarringDangerous, float MaxCarryWeight, Color color, AmountCarDoors amount)
        {

            if (Vehicle_type == (VehicleType)1)
            {
                var vehicle = CreateFuelCar(Engine_type, License_plate, owner_name, owner_phone, amountOfGas);
                CarSpecifics(vehicle,typeOfTires,color,amount);
                return vehicle;
            }
            if (Vehicle_type == (VehicleType)2)
            {
                var vehicle = CreateFuelTruck(Engine_type, License_plate, owner_name, owner_phone, amountOfGas);
                TruckSpecifics(vehicle,typeOfTires,IsCarringDangerous,MaxCarryWeight);
                return vehicle;
            }
            if (Vehicle_type == (VehicleType)3)
            {
                var vehicle = CreateFuelMotorcycle(Engine_type, License_plate, owner_name, owner_phone, amountOfGas);
                MotorcycleSpecifics(vehicle,typeOfTires,type,EngineCapacity);
                return vehicle;
            }

            return null;
        }

        //assemblieng electric vehicles:
        public static Vehicle ElectricAssemblyLine(Engine Engine_type,string License_plate,string owner_name,string owner_phone,string model, float amountOfEnergy,VehicleType Vehicle_type, int typeOfTires, LicenseType type, int EngineCapacity, bool IsCarringDangerous, float MaxCarryWeight, Color color, AmountCarDoors amount)
        {

            if (Vehicle_type == (VehicleType)1)
            {
                var vehicle=CreateElectricCar(Engine_type,License_plate,owner_name,owner_phone,amountOfEnergy);
                CarSpecifics(vehicle, typeOfTires, color, amount);
                return vehicle;
            }
            if (Vehicle_type == (VehicleType)2)
            {
                var vehicle = CreateElectricTruck(Engine_type, License_plate, owner_name, owner_phone, amountOfEnergy);
                TruckSpecifics(vehicle, typeOfTires, IsCarringDangerous, MaxCarryWeight);
                return vehicle;
            }
            if (Vehicle_type == (VehicleType)3)
            {
                var vehicle = CreateElectricMotorcycle(Engine_type, License_plate, owner_name, owner_phone, amountOfEnergy);
                MotorcycleSpecifics(vehicle, typeOfTires, type, EngineCapacity);
                return vehicle;
            }
            return null;

        }


        //Creating Electric vehicles:
        public static Car CreateElectricCar(Engine Engine_type, string License_plate, string owner_name, string owner_phone, float amountOfEnergy)
        {
            //Car vehicle = new Car(Engine_type, License_plate, owner_name, owner_phone);
            var vehicle = new Car(Engine_type, License_plate, owner_name, owner_phone);
            vehicle.SetStateOfVehicle(1);
            vehicle.SetTypeOfVehicle(1);
            vehicle.SetCurrentAmountOfEnergy(amountOfEnergy);
            return vehicle;
        }

        public static Truck CreateElectricTruck(Engine Engine_type, string License_plate, string owner_name, string owner_phone, float amountOfEnergy)
        {
            Truck vehicle = new Truck(Engine_type, License_plate, owner_name, owner_phone);
            vehicle.SetStateOfVehicle(1);
            vehicle.SetTypeOfVehicle(2);
            vehicle.SetCurrentAmountOfEnergy(amountOfEnergy);
            return vehicle;
        }

        public static Motorcycle CreateElectricMotorcycle(Engine Engine_type, string License_plate, string owner_name, string owner_phone, float amountOfEnergy)
        {
            Motorcycle vehicle = new Motorcycle(Engine_type, License_plate, owner_name, owner_phone);
            vehicle.SetStateOfVehicle(1);
            vehicle.SetTypeOfVehicle(3);
            vehicle.SetCurrentAmountOfEnergy(amountOfEnergy);
            return vehicle;
        }

        //Creating fuel vehicles:
        public static Car CreateFuelCar(Engine Engine_type, string License_plate, string owner_name, string owner_phone,float AmountOfFuel)
        {
            Car vehicle = new Car(Engine_type, License_plate, owner_name, owner_phone);
            vehicle.SetStateOfVehicle(1);
            vehicle.SetTypeOfVehicle(1);
            vehicle.SetCurrentAmountOfFuel(AmountOfFuel);
            return vehicle;
        }

        public static Truck CreateFuelTruck(Engine Engine_type, string License_plate, string owner_name, string owner_phone, float AmountOfFuel)
        {
            Truck vehicle = new Truck(Engine_type, License_plate, owner_name, owner_phone);
            vehicle.SetStateOfVehicle(1);
            vehicle.SetTypeOfVehicle(2);
            vehicle.SetCurrentAmountOfFuel(AmountOfFuel);
            return vehicle;
        }

        public static Motorcycle CreateFuelMotorcycle(Engine Engine_type, string License_plate, string owner_name, string owner_phone, float AmountOfFuel)
        {
            Motorcycle vehicle = new Motorcycle(Engine_type, License_plate, owner_name, owner_phone);
            vehicle.SetStateOfVehicle(1);
            vehicle.SetTypeOfVehicle(3);
            vehicle.SetCurrentAmountOfFuel(AmountOfFuel);
            return vehicle;
        }

        //vehicles specifics:
        public static void CarSpecifics(Vehicle vehicle,int typeOfTires,Color color,AmountCarDoors amount)
        {
            vehicle.SetColor((int)color);
            vehicle.SetAmountOfDoors((int)amount);
            vehicle.SetTypeOfTires(typeOfTires);

        }
        public static void TruckSpecifics(Vehicle vehicle, int typeOfTires,bool IsCarringDangerous,float maxCarryWeight)
        {
            if (IsCarringDangerous)
            {
                vehicle.SetDangerousSubstance(1);
            }
            else {
                vehicle.SetDangerousSubstance(0);
            }
            vehicle.SetMaxCargoWeight(maxCarryWeight);
            vehicle.SetTypeOfTires(typeOfTires);
        }
        public static void MotorcycleSpecifics(Vehicle vehicle, int typeOfTires,LicenseType type,int EngineCapacity)
        {
            vehicle.SetLicenseType((int)type);
            vehicle.SetEngineVolume(EngineCapacity);
            vehicle.SetTypeOfTires(typeOfTires);
        }
    }
}
