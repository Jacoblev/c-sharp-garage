namespace Garage.GeneralLogic
{
    public class Truck:Vehicle
    {
        int AmountOfTires = 12;
        new float PSI = 34;
        readonly float maxPSI = 34;
        public float Current_PSI;
        GasType Type = (GasType)3;
        bool Dangerous_substance;
        float Max_Cargo_Weight;
        public new StateOfVehicle state;
        public new float Energy_left_In_hours;
        public new float Energy_max_in_hours = 200;
        public int MaxAmountOfFuel;

        public Truck(Engine engi, string LicepPlate, string ownersName, string ownersPhoneNumber)
        {
            engine = engi;
            Owners_name = ownersName;
            Owners_phone_number = ownersPhoneNumber;
            License_Plate = LicepPlate;
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

        //PSI:
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

        public override GasType SetGasType(int input)
        {
            type = (GasType)input;

            return type;
        }
        public override GasType GetGasType()
        {
            return type;
        }
        public override float GasTankSize()
        {
            return (Gas_tank = 130);

        }
        //electric:
        public override float GetMaxEnergyLevel()
        {
            
            Energy_max_in_hours = 100;
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

        //model:
        public override string GetModel()
        {

            return Model; ;
        }
        public override string SetModel(string input)
        {
            Model = input;
            return Model; ;
        }
        //Is carrying Dangerous substance:
        public override bool SetDangerousSubstance(int input)
        {
            if (input==1)
            {
                Dangerous_substance = true;
            }
            if (input==0)
            {
                Dangerous_substance = false;
            }

            return Dangerous_substance;
        }
        public override bool GetDangerousSubstance()
        {
            return Dangerous_substance;
        }

        //max weight cargo:
        public override float SetMaxCargoWeight(float input)
        {

            Max_Cargo_Weight = input;
            return Max_Cargo_Weight;
        }
        public override float GetMaxCargoWeight()
        {
            return Max_Cargo_Weight;
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
                else
                {
                    return null;
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
            vehicleType =(VehicleType) 2;
            return vehicleType;
        }
    }
}
