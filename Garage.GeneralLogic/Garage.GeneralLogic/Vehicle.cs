namespace Garage.GeneralLogic
{
    public abstract class Vehicle
    {

        protected string License_Plate;
        protected string Owners_name;
        protected string Owners_phone_number;
        protected Engine engine;
        protected float current_PSI;
        protected float Gas_tank;
        protected string Model;
        public int typeOfTire;
        protected float Max_PSI;
        protected string nameOfTireManufacturer;
        protected float Current_amount_of_fuel;
        protected float Energy_left_In_hours;
        protected float Energy_max_in_hours=100;
        protected bool Dangerous_substance;
        protected float Max_Cargo_Weight;
        protected VehicleType vehicleType;
        protected StateOfVehicle state;
        protected GasType type;
        protected AmountCarDoors amountCarDoors;
        protected LicenseType License_type;
        protected int EngineVolume;
        protected Color Car_color;

        public enum VehicleType
        {
            Car = 1,
            Truck = 2,
            Motorcycle = 3
        }



        public Vehicle()
        {

        }
        public Vehicle(Engine engi, string LicepPlate, string ownersName, string ownersPhoneNumber)
        {
         
        }
        public virtual string GetLicensePlate()
        {
            return License_Plate;
        }
        public virtual Engine GetEngineType() {
            return engine;
        }
        //state:
        public virtual StateOfVehicle GetState()
        {
            return state;
        }
        public virtual StateOfVehicle SetStateOfVehicle(int input)
        {
            state = (StateOfVehicle)input;
            return state;
        }

        //PSI:
        public virtual float GetCurrentPSI()
        {
            return (current_PSI);
        }
        public virtual float SetCurrentPSI(int input)
        {
            current_PSI = input;
            return (current_PSI);
        }
        public virtual float GetMaxPSI()
        {
            return (Max_PSI);
        }

        //fuel:
        public virtual float GasTankSize()
        {
            return (Gas_tank);
        }
        public virtual float GetCurrentAmountOfFuel()
        {
            return (Current_amount_of_fuel);
        }
        public virtual float SetCurrentAmountOfFuel(float input)
        {
            Current_amount_of_fuel = input;
            return (Current_amount_of_fuel);
        }
        public virtual GasType SetGasType(int input)
        {
            type = (GasType)input;
            return type;
        }
        public virtual GasType GetGasType()
        {
            return type;
        }
        //Electric
        public virtual float GetMaxEnergyLevel()
        {
            Energy_max_in_hours = 100;
            return (Energy_max_in_hours);
        }
        public virtual float GetCurrentAmountOfEnergy()
        {
            return (Energy_left_In_hours);
        }
        public virtual float SetCurrentAmountOfEnergy(float input)
        {
            Energy_left_In_hours = input;
            return (Energy_left_In_hours);
        }
       
        //color
        public virtual Color SetColor(int input)
        {
            Car_color = (Color) input;

            return Car_color;
        }
        public virtual Color GetColor()
        {
        return Car_color;

        }

        //amount of doors
        public virtual AmountCarDoors SetAmountOfDoors(int input)
        {
            amountCarDoors = (AmountCarDoors)input;

            return amountCarDoors;
        }
        public virtual AmountCarDoors GetAmountOfDoors()
        {
            return amountCarDoors;
        }


        //Is carrying Dangerous substance:
        public virtual  bool SetDangerousSubstance(int input)
        {
            if (input==1)
            {
                Dangerous_substance = true;
            }
            if(input==0)
            {
                Dangerous_substance = false;
            }

            return Dangerous_substance;
        }
        public virtual  bool GetDangerousSubstance()
        {
            return Dangerous_substance;
        }


        //max weight cargo:
        public virtual  float SetMaxCargoWeight(float input)
        {

            Max_Cargo_Weight = input;
            return Max_Cargo_Weight;
        }
        public virtual float GetMaxCargoWeight()
        {
            return Max_Cargo_Weight;
        }


        //model:
        public virtual string SetModel(string input)
        {
            Model = input;
            return Model; ;
        }
        public virtual string GetModel()
        {
            return Model; ;
        }

        //Type of License
        public virtual LicenseType SetLicenseType(int input)
        {
            License_type =(LicenseType)input;

            return License_type;
        }
        public virtual  LicenseType GetLicenseType()
        {
            return License_type;
        }

        //Engine Capacity:
        public virtual int SetEngineVolume(int input)
        {
            EngineVolume = input;
            return EngineVolume;
        }
        public virtual int GetEngineVolume()
        {
            return EngineVolume;
        }
        //Type of tire
        public virtual int SetTypeOfTires(int input)
        {
            
            typeOfTire = input;
            return typeOfTire;
        }
        public virtual string GetTypeOfTires(int input)
        {
            foreach (var item in Factory.TireList)
            {
                if (item.GetBarcode()==typeOfTire)
                {
                    nameOfTireManufacturer= item.GetManufacturer();
                    return nameOfTireManufacturer;
                }
                else
                {
                    return null;
                }
            }
            return nameOfTireManufacturer;
        }
        //type of vehicle:
        public virtual VehicleType GetTypeOfVehicle()
        {

            return vehicleType;
        }
        public virtual VehicleType SetTypeOfVehicle(int input)
        {
            return vehicleType;
        }

    }

}