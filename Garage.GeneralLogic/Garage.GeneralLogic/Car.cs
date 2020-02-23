namespace Garage.GeneralLogic
{
    public class Car:Vehicle
    {

        int Amount_of_tires = 4;
        GasType type;
        Color color;
        readonly float Max_PSI=32;
        float Current_amount_of_fuel;
        float Energy_left_In_hours;
        float Energy_max_in_hours=60;
        AmountCarDoors amount_of_car_doors;
        public StateOfVehicle state;
        

        public Car()
        {

        }

        public Car(Engine e, string LicePlate, string ownersName, string ownersPhoneNumber)
        {
            engine = e;
            Owners_name = ownersName;
            Owners_phone_number = ownersPhoneNumber;
            License_Plate = LicePlate;
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

        //PSI
        public override float SetCurrentPSI(int input)
        {
            current_PSI = input;
            return (current_PSI);
        }
        public override float GetCurrentPSI()
        {
            return (current_PSI);
        }

        public override float GetMaxPSI()
        {
            return (Max_PSI);
        }

        //fuel
        public override float GasTankSize()
        {
            return (Gas_tank = 50);
        }
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

        public override GasType GetGasType()
        {
            return type;
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
        //color:
        public override Color SetColor(int input)
        {
            color = (Color)input;

            return color;
        }
        public override Color GetColor()
        {
            return color;
        }
        //Amount of doors:
        public override AmountCarDoors SetAmountOfDoors(int input)
        {
            amount_of_car_doors= (AmountCarDoors)input;

            return amount_of_car_doors;
        }
        public override AmountCarDoors GetAmountOfDoors()
        {
            return amount_of_car_doors;
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
            vehicleType = (VehicleType)1;
            return vehicleType;
        }
    }
}
