namespace Garage.GeneralLogic
{
    public class Motorcycle : Vehicle
    {

        int AmountOfTires = 2;

        GasType type = (GasType)2;
        readonly float Max_PSI = 28;

        public float Current_PSI;
        LicenseType License_type;

        int EngineVolume;
        public new StateOfVehicle state;

        public int Max_amount_of_fuel;
        public new float Current_amount_of_fuel;

        public new float Energy_left_In_hours;

        public Motorcycle()
        {

        }

        public Motorcycle(Engine engi, string LicepPlate, string ownersName, string ownersPhoneNumber)
        {
            engine = engi;
            Owners_name = ownersName;
            Owners_phone_number = ownersPhoneNumber;
            License_Plate = LicepPlate;
        }

        //PSI
        public override float SetCurrentPSI(int input)
        {
            current_PSI = input;
            return (current_PSI);
        }
        public override float GetCurrentPSI()
        {
            return (Current_PSI);
        }

        public override float GetMaxPSI()
        {
            return (Max_PSI);
        }

        //fuel
        public override float GetCurrentAmountOfFuel()
        {
            return (Current_amount_of_fuel);
        }
        public override float SetCurrentAmountOfFuel(float input)
        {
            Current_amount_of_fuel = input;
            return (Current_amount_of_fuel);
        }
        public override GasType GetGasType()
        {
            return type;
        }
        public override GasType SetGasType(int input)
        {
            type = (GasType)input;

            return type;
        }
        public override float GasTankSize()
        {
            return (Gas_tank = 5.5f);
        }
        //electric
        public override float GetMaxEnergyLevel()
        {
            Energy_max_in_hours = 110;
            return (Energy_max_in_hours);
        }
        public override float GetCurrentAmountOfEnergy()
        {
            return (Energy_left_In_hours);
        }
        public override float SetCurrentAmountOfEnergy(float input)
        {
            Energy_left_In_hours = input;
            return (Energy_left_In_hours);
        }
        //state
        public override StateOfVehicle GetState()
        {
            return state;
        }
        public override StateOfVehicle SetStateOfVehicle(int input)
        {
            state = (StateOfVehicle)input;
            return state;
        }

        //model
        public override string GetModel()
        {

            return Model; ;
        }
        public override string SetModel(string input)
        {
            Model = input;
            return Model; ;
        }
        
        //Type of License
        public override LicenseType SetLicenseType(int input)
        {
            License_type =(LicenseType)input;

            return License_type;
        }
        public override LicenseType GetLicenseType()
        {
            return License_type;
        }

        //Engine Capacity:
        public override int SetEngineVolume(int input)
        {
            EngineVolume = input;
            return EngineVolume;
        }
        public override int GetEngineVolume()
        {
            return EngineVolume;
        }
        //Type of tire
        public override int SetTypeOfTires(int input)
        {
            typeOfTire = input;
            return typeOfTire;
        }
        public override string GetTypeOfTires(int input)
        {
            foreach (var item in Factory.TireList)
            {
                if (item.GetBarcode() == typeOfTire)
                {
                    nameOfTireManufacturer = item.GetManufacturer();
                    return nameOfTireManufacturer;
                }
            }
            return nameOfTireManufacturer;
        }
        //type of vehicle
        public override VehicleType GetTypeOfVehicle()
        {
            return vehicleType;
        }
        public override VehicleType SetTypeOfVehicle(int input)
        {
            vehicleType = (VehicleType)3;
            return vehicleType;
        }
    }
}
