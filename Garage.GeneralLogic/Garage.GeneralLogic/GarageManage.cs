using System.Collections.Generic;

namespace Garage.GeneralLogic
{
    public class GarageManage:Factory
    {
       public Factory factory = new Factory();

        public GarageManage()
        {

        }

        static List<Vehicle> GarageVehicleList = new List<Vehicle>();


        /// <summary>
        /// TEST CARS
        /// </summary>
        /// 
        public static void TestObject()
        {
            Car testCar1 = new Car((Engine)1, "asd1", "Tesla_Test_Car", "054666");
            testCar1.SetStateOfVehicle(1);
            testCar1.SetCurrentAmountOfEnergy(40);
            testCar1.SetCurrentPSI(20);
            testCar1.SetModel("Tesla_Test_Car");
            testCar1.SetAmountOfDoors(1);
            testCar1.SetColor(3);
            testCar1.SetTypeOfTires(1);
            testCar1.SetTypeOfVehicle(1);
            AddVehicleToGarage(testCar1);

            Car testCar2 = new Car((Engine)2, "asd2", "Ford_Test_Car", "054777");
            testCar2.SetStateOfVehicle(3);
            testCar2.SetCurrentAmountOfFuel(25);
            testCar2.SetAmountOfDoors(3);
            testCar2.SetModel("Ford_Test_Car");
            testCar2.SetCurrentPSI(32);
            testCar2.SetColor(1);
            testCar2.SetTypeOfVehicle(1);
            testCar2.SetGasType(1);
            testCar2.SetTypeOfTires(2);
            AddVehicleToGarage(testCar2);

        }

        public static Vehicle StartElectricAssembly(Engine Engine_type,string License_plate,string owner_name,string owner_phone, string model, float amountOfEnergy,VehicleType Vehicle_type, int typeOfTires, LicenseType type, int EngineCapacity, bool IsCarringDangerous, float MaxCarryWeight, Color color, AmountCarDoors amount)
        {
            var vehicle = Factory.ElectricAssemblyLine(Engine_type, License_plate, owner_name, owner_phone, model, amountOfEnergy, Vehicle_type,typeOfTires,type,EngineCapacity,IsCarringDangerous,MaxCarryWeight,color,amount);
            return vehicle;
        }

        public static Vehicle StartFuelAssembly(Engine Engine_type,string License_plate,string owner_name,string owner_phone,string model,float amountOfGas,VehicleType Vehicle_type, int typeOfTires, LicenseType type, int EngineCapacity, bool IsCarringDangerous, float MaxCarryWeight, Color color, AmountCarDoors amount)
        {
            var vehicle =Factory.FuelAssemblyLine(Engine_type,License_plate,owner_name,owner_phone,model,amountOfGas,Vehicle_type,typeOfTires,type,EngineCapacity,IsCarringDangerous,MaxCarryWeight,color,amount);
            return vehicle;
        }
    

        //adding vehicle to garage.
        public static void AddVehicleToGarage(Vehicle vehicle)
        {
            GarageVehicleList.Add(vehicle);
        }
        
        //checking if vehicle in garage.
        public static string CheckVehicleInGarage(string License_plate) {
            foreach (var item in GarageVehicleList) {
                if (item.GetLicensePlate() == License_plate)
                {
                    return License_plate;
                }
            }
            return null;
        }

        //returning garagelist ordered by status.
        public static List<Vehicle> GetGarageList(int selection)
        {
            if (selection == 1) {
                var TempList = new List<Vehicle>();
                foreach (var item in GarageVehicleList)
                {
                    if (item.GetState()==(StateOfVehicle)1)
                    {
                        Vehicle TempVehicle = item;
                        TempList.Add(TempVehicle);
                    }
                    
                }
                return TempList;
            }
            if (selection == 2) {
                var TempList = new List<Vehicle>();
                foreach (var item in GarageVehicleList)
                {
                    if (item.GetState() == (StateOfVehicle)2)
                    {
                        Vehicle TempVehicle = item;
                        TempList.Add(TempVehicle);
                    }
                }
                return TempList;
            }
            if (selection == 3)
            {
                var TempList = new List<Vehicle>();
                foreach (var item in GarageVehicleList)
                {
                    if (item.GetState() == (StateOfVehicle)3)
                    {
                        Vehicle TempVehicle = item;
                        TempList.Add(TempVehicle);
                    }
                }
                return TempList;
            }
            if (selection == 4)
            {
                var TempList = new List<Vehicle>();
                foreach (var item in GarageVehicleList)
                {
                 Vehicle TempVehicle = item;
                 TempList.Add(TempVehicle);
                }
                return TempList;
            }
            return null;
        }

        //changing status of the vehicle in garage.
        public static void ChangeVehicleStatus(string License_plate,int status_selected) {
            foreach (var item in GarageVehicleList)
            {
                if (item.GetLicensePlate() == License_plate)
                {
                    item.SetStateOfVehicle(status_selected);
                }
            }
        }

        //inflating tires of the vehicle
        public static bool InflateTires(string License_plate) {

            foreach (var item in GarageVehicleList)
            {
                if (item.GetLicensePlate() == License_plate)
                {
                    if (item.GetCurrentPSI() < item.GetMaxPSI())
                    {
                        item.SetCurrentPSI((int)item.GetMaxPSI());
                        return true;//inflated
                    }
                }
               
            }
            return false;
        }

        //Refueling the vehicle
        public static bool RefuelVehicle(string License_plate, GasType type, float Amount_to_fuel)
        {


            foreach (var item in GarageVehicleList)
            {
                if (item.GetLicensePlate() == License_plate)
                {
                    if (item.GetGasType() == type)
                    {
                        if ((item.GetCurrentAmountOfFuel() + Amount_to_fuel) <= item.GasTankSize())
                        {
                            item.SetCurrentAmountOfFuel((item.GetCurrentAmountOfFuel() + Amount_to_fuel));
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        //Refueling the vehicle
        public static bool ReChargeVehicle(string License_plate, float Amount_of_minutes_to_charge)
        {
            foreach (var item in GarageVehicleList)
            {
                if (item.GetLicensePlate() == License_plate && item.GetEngineType()==(Engine)1)
                {
                    float Energy_percentage = Amount_of_minutes_to_charge/2;
                    if (item.GetCurrentAmountOfEnergy()+ Energy_percentage <= item.GetMaxEnergyLevel())
                    {
                        item.SetCurrentAmountOfEnergy(item.GetCurrentAmountOfEnergy() + Energy_percentage);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        //checks the type of the engine installed in the car.
        public static int EngineChecker(string License_plate) {
            foreach (var item in GarageVehicleList)
            {
                if (item.GetLicensePlate() == License_plate)
                {
                    if (item.GetEngineType() == (Engine)1) {
                        return 1;
                    }
                    if (item.GetEngineType() == (Engine)2)
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }
        //getting currents amounts of fuel\energy
        public static float GetCurrentAmountOfFuel(string License_plate)
        {
            foreach (var item in GarageVehicleList)
            {
                if (item.GetLicensePlate() == License_plate)
                {
                    return item.GetCurrentAmountOfFuel();
                }
            }
            return 0;
        }
        public static float GetCurrentAmountOfEnergy(string License_plate)
        {
            foreach (var item in GarageVehicleList)
            {
                if (item.GetLicensePlate() == License_plate)
                {
                    return item.GetCurrentAmountOfEnergy();
                }
            }
            return 0;
        }
        //info getting from selected vehicle
        public static Vehicle TargetVehicleInfo(string License_plate) {
            foreach (var item in GarageVehicleList)
            {
                if (item.GetLicensePlate() == License_plate)
                {
                    return item;
                }
            }
            return null;
        }
        //Car info


    }
}
