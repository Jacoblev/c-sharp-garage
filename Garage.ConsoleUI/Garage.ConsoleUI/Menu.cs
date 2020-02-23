using System;
using Garage.GeneralLogic;
namespace Garage.ConsoleUI
{
    public class Menu
    {
        
        /// Main Menu 

        public void GarageMenu()
        {
            int Choice;
            Console.WriteLine("(|////////////////////////////////////////////////////|)");
            System.Console.WriteLine("1. Enter new vehicle to garage.\n");
            System.Console.WriteLine("2. Show license list of cars in garage.\n");
            System.Console.WriteLine("3. Change state of car.\n");
            System.Console.WriteLine("4. Inflate Tires of vehicle.\n");
            System.Console.WriteLine("5. Refuel vehicle with gas.\n");
            System.Console.WriteLine("6. Charge electric vehicle.\n");
            System.Console.WriteLine("7. Display full info of a vehicle.\n");
            Console.WriteLine("(|////////////////////////////////////////////////////|)");
            
            try
            {
                Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        NewVehicleMenu();
                        BackToMain();
                        break;

                    case 2:
                        ListOfVehiclesMenu();
                        BackToMain();
                        break;

                    case 3:
                        StateOfCarMenu();
                        BackToMain();
                        break;

                    case 4:
                        InflateTiresMenu();
                        BackToMain();
                        break;

                    case 5:
                        RefuelMenu();
                        BackToMain();
                        break;

                    case 6:
                        RechargeMenu();
                        BackToMain();
                        break;

                    case 7:
                        PresentFullInfoMenu();
                        BackToMain();
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You cant do that , Wrong input {0}",ex);
                throw;
            }
        }

        ///Back to Main Menu Handling
        void BackToMain()
        {
            int select;
            Console.WriteLine("Go to main Menu[1] /Exit[2] ?");
            select=int.Parse(Console.ReadLine());
            if (select==1)
            {
                Console.Clear();
                GarageMenu();
            }
            else if(select == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                WrongInput();
            }
        }

        
        /// Exeptions:
        public void WrongInput()
        {//used in wrong input
            Console.WriteLine("Wrong input, you cant do that.");
        }
        public void WrongLogicalInput()
        {//used in wrong choice (Example: fueling electric car)
            Console.WriteLine("Wrong choice, you cant do that.");
        }
        public void WrongAmountInput()
        {//used in wrong amount (Example: fueling car beyond its tank size limit.)
            Console.WriteLine("Wrong amount, you cant do that.");
        }

        ///Gets Inputs from user:
        public string GetFromUserLicensePlate()
        {
            string License_plate;
            License_plate = Console.ReadLine();

            return License_plate;
        }

        public string GetFromUserName()
        {
            string Owner_name;
            Owner_name = Console.ReadLine();

            return Owner_name;
        }

        public string GetFromUserPhone()
        {
            string Owner_phone;
            Owner_phone = Console.ReadLine();

            return Owner_phone;
        }

        //Technical details for each vehicle
        public Engine GetFromUserEngineType()
        {
            Engine Engine_type;
            Console.WriteLine("Enter Type of engine:");
            Console.WriteLine("Electric[1],Fuel[2]");
            Engine_type = (Engine)Enum.Parse(typeof(Engine), Console.ReadLine());

            return Engine_type;
        }
        public string GetFromUserModel()
        {
            string model;
            Console.WriteLine("Enter model of your vehicle:");
            model = Console.ReadLine();

            return model;
        }

        public GasType GetFromUserGasType()
        {
            GasType Gas_type;
            Console.WriteLine("Enter Type of gas:");
            Console.WriteLine("[1]Octan98");
            Console.WriteLine("[2]Octan95");
            Console.WriteLine("[3]Octan96");
            Console.WriteLine("[4]Soler");
            Gas_type = (GasType)Enum.Parse(typeof(GasType), Console.ReadLine());

            return Gas_type;
        }
        public int GetTypeOfTire() {
            Console.WriteLine("What tires are on your vehicle ?");
            Console.WriteLine("[1]Pirelli");
            Console.WriteLine("[2]Dunlop");
            Console.WriteLine("[3]GoodYear");
            Console.WriteLine("[4]Kumho");
            Console.WriteLine("[5]Hankook");
          
            int type = int.Parse(Console.ReadLine());
            return type;
        }
        public Vehicle.VehicleType GetFromUserVehicleType()
        {
            Vehicle.VehicleType Type;
            Console.WriteLine("Enter Type of vehicle:");
            Console.WriteLine("Car[1],Truck[2],Motorcycle[3]");
            Type = (Vehicle.VehicleType)Enum.Parse(typeof(Vehicle.VehicleType), Console.ReadLine());
            return Type;
        }

        //Details for Car:
        public Color GetCarColorFromUser() {
            Console.WriteLine("Select the color of your car:");
            Console.WriteLine("[1]Green");
            Console.WriteLine("[2]Silver");
            Console.WriteLine("[3]White");
            Console.WriteLine("[4]Black");
            Color color=(Color)Enum.Parse(typeof(Color),Console.ReadLine());
            return color;
        }

        public AmountCarDoors GetAmountOfDoorsFromUser() {
            Console.WriteLine("Select the amount of doors in your car:");
            Console.WriteLine("[1] Two");
            Console.WriteLine("[2]Three");
            Console.WriteLine("[3]Four");
            Console.WriteLine("[4]Five");
            AmountCarDoors amount = (AmountCarDoors)Enum.Parse(typeof(AmountCarDoors), Console.ReadLine());
            return amount;
        }

        //Details for Truck:
        public bool IsCarringDangerousSubstance() {
            Console.WriteLine("Is Truck Carring Dangerous Substance?");
            Console.WriteLine("[1]Yes.");
            Console.WriteLine("[2]NO.");
            int select=int.Parse(Console.ReadLine());
            if (select == 1) {
                return true;
            }
            if (select==2)
            {
                return false;
            }
            return true;
        }

        public float GetMaximumCarryWeight() {
            
            Console.WriteLine("What is the maximum weight that the truck can carry?");
            float weight=float.Parse(Console.ReadLine());
            return weight;
        }

        //Details for Motorcycle:
        public LicenseType GetLicenseType() {
            LicenseType type;
            Console.WriteLine("what license type you have ?");
            Console.WriteLine("[1]A1");
            Console.WriteLine("[2]B1");
            Console.WriteLine("[3]AA");
            Console.WriteLine("[4]BB");
            type = (LicenseType)Enum.Parse(typeof(LicenseType), Console.ReadLine());
            return type;
        }

        public int GetEngineVolume() {
            Console.WriteLine("What's your engine capacity? ");
            int capacity = int.Parse(Console.ReadLine());
            return capacity;
        }

        //Gas Details:
        public float GetCurrentAmountOfGas()
        {
            Console.WriteLine("Enter The current amount of gas you have in your vehicle:");
            float amount = float.Parse(Console.ReadLine());

            return amount;
        }

        //Energy Details:
        public float GetCurrentAmountOfEnergy()
        {
            Console.WriteLine("Enter The current amount of Energy you have in your vehicle:");
            float amount = float.Parse(Console.ReadLine());

            return amount;
        }

        //Vehicle Creator ->Contacts factory ->Creates Vehicle->Adds it to GarageList.
        public Vehicle GetVehicleDetails(string License_plate)
        {
            float amountOfEnergy=0;
            GasType Gas_type=0;
            float amountOfGas = 0;
            Color color=0;
            AmountCarDoors amount=0;
            bool isCarringDangerous=true;
            float MaximumCarryWeight=0;
            int typeOfTires=0;
            LicenseType type=0;
            int EngineCapacity=0;
            string model;
            Console.WriteLine("Enter owners name:");
            string owner_name = GetFromUserName();

            Console.WriteLine("Enter owners phone:");
            string owner_phone = GetFromUserPhone();

            Vehicle.VehicleType Vehicle_type =GetFromUserVehicleType();
            model=GetFromUserModel();

            //Acumilating details depends on the engine type selected.
            Engine Engine_type = GetFromUserEngineType();
            if (Engine_type == (Engine)2)//fuel info
            {
                Gas_type = GetFromUserGasType();
                amountOfGas = GetCurrentAmountOfGas();
            }
            if (Engine_type == (Engine)1)//electric info
            {
                amountOfEnergy = GetCurrentAmountOfEnergy();
            }

            //Acumilating details depending on the vehicle type selected
            if (Vehicle_type == (Vehicle.VehicleType)1) {//car
                color= GetCarColorFromUser();
                amount= GetAmountOfDoorsFromUser();
                typeOfTires = GetTypeOfTire();
            }
            if (Vehicle_type == (Vehicle.VehicleType)2) {//truck
                isCarringDangerous = IsCarringDangerousSubstance();
                MaximumCarryWeight = GetMaximumCarryWeight();
                typeOfTires = GetTypeOfTire();
            }
            if (Vehicle_type == (Vehicle.VehicleType)3){//motorcycle
                type= GetLicenseType();
                EngineCapacity= GetEngineVolume();
                typeOfTires = GetTypeOfTire();
            }
            //addressing the factory with the request to create a vehicle with the specifications.
            if (Engine_type == (Engine)1) {
                var vehicle = GarageManage.StartElectricAssembly(Engine_type, License_plate, owner_name, owner_phone, model, amountOfEnergy, Vehicle_type, typeOfTires, type, EngineCapacity, isCarringDangerous, MaximumCarryWeight, color, amount);

                return vehicle;
            }
            if (Engine_type == (Engine)2){
                var vehicle=GarageManage.StartFuelAssembly(Engine_type, License_plate, owner_name, owner_phone,model,amountOfGas, Vehicle_type, typeOfTires, type, EngineCapacity, isCarringDangerous, MaximumCarryWeight, color, amount);
                return vehicle;
            }
            return null;
        }

        //selector
        public int GetFromUserSelection()
        {
            int select;
        
            select = int.Parse(Console.ReadLine());
            return select;
        }


        ///Functions that present menu of each option in menu.

        public void NewVehicleMenu() {//1

            Console.WriteLine("To enter new car to garage:");
            Console.WriteLine("Enter license plate to check:");
            string License_plate =GetFromUserLicensePlate();
            if (GarageManage.CheckVehicleInGarage(License_plate)==null)
            {
                
                Console.WriteLine("You can enter the car to the garage!");
                Console.WriteLine("Enter Details:");
                GarageManage.AddVehicleToGarage(GetVehicleDetails(License_plate));
                Console.WriteLine("Success, Vehicle added to Garage!");
            }
            
            else
            {
                Console.WriteLine("there is already vehicle with that license number");
            }
        }

        public void ListOfVehiclesMenu() {//2
            int i=0;
            Console.WriteLine("Sort list of vehicles by:");
            Console.WriteLine("Under Maintance[1]");
            Console.WriteLine("Repaired[2]");
            Console.WriteLine("Paid[3]");
            Console.WriteLine("No sort[4]");
            foreach (var item in GarageManage.GetGarageList(GetFromUserSelection()))
            {
                i++;
                Console.WriteLine("{0}. Plate number: {1} ,Status: {2}",i, item.GetLicensePlate(), item.GetState());
            }
        }

        public void StateOfCarMenu() {//3
            Console.WriteLine("To change state of car:");
            Console.WriteLine("Enter License plate:");
            string License_plate = GarageManage.CheckVehicleInGarage(GetFromUserLicensePlate());
            int status_selected;
            if (License_plate!=null)
            {
                Console.WriteLine("Vehicle Found!");
                Console.WriteLine("To what status you want to change it ?");
                Console.WriteLine("Under Maintance[1]");
                Console.WriteLine("Repaired[2]");
                Console.WriteLine("Paid[3]");
                status_selected =int.Parse( Console.ReadLine());
                GarageManage.ChangeVehicleStatus(License_plate,status_selected);
                Console.WriteLine("Success, Status changed!");
            }
            else
            {
                Console.WriteLine("There is no such plate number in list.");
            }
        }

        public void InflateTiresMenu(){//4

            Console.WriteLine("To inflate tires:");
            Console.WriteLine("Enter License plate:");
            string License_plate = GarageManage.CheckVehicleInGarage(GetFromUserLicensePlate());
            if (License_plate!=null)
            {
                Console.WriteLine("Success, Vehicle Found!");
                if (GarageManage.InflateTires(License_plate)) {
                    Console.WriteLine("Success, Tires Inflated!");
                }
                else{
                    Console.WriteLine("Tires are Full already!");
                }
            }
            else
            {
                Console.WriteLine("There is no such car , please search again.");
                BackToMain();
            }
        }
        public void RefuelMenu()//5
        {
            Console.WriteLine("To Refuel vehicle:");
            Console.WriteLine("Enter License plate:");
            string License_plate=GetFromUserLicensePlate();
            if (License_plate!=null && GarageManage.EngineChecker(License_plate)==2)
            {
                Console.WriteLine("Success Vehicle Found and ready to be fueled !");
                Console.WriteLine("Current amount of fuel is:{0}", GarageManage.GetCurrentAmountOfFuel(License_plate));
                GasType type=GetFromUserGasType();
                
                Console.WriteLine("Enter Amount of fuel you want to fuel:");
                float Amount_to_fuel=float.Parse(Console.ReadLine());

                if (GarageManage.RefuelVehicle(License_plate, type, Amount_to_fuel)) {
                    Console.WriteLine("Amount of fuel after refuel: {0}", GarageManage.GetCurrentAmountOfFuel(License_plate));
                    Console.WriteLine("Success Vehicle Refueled!");
                }
                else
                {
                    Console.WriteLine("Fuel problem, (Check your fuel type)/(Check your amount of fuel)");
                    BackToMain();
                }
            }
            else
            {
                Console.WriteLine("There is no such car /or car isnt Fuel type.");
                BackToMain();
            }
        }
        public void RechargeMenu()//6
        {
            Console.WriteLine("To Recharge vehicle:");
            Console.WriteLine("Enter License plate:");
            string License_plate = GetFromUserLicensePlate();

            if (License_plate != null && GarageManage.EngineChecker(License_plate) == 1)
            {
                Console.WriteLine("Success Vehicle Found & ready to be charged !");
                Console.WriteLine("Current amount of energy is: {0}", GarageManage.GetCurrentAmountOfEnergy(License_plate));

                Console.WriteLine("Enter Amount of minutes you want to charge:");
                float Amount_of_minutes_to_charge = float.Parse(Console.ReadLine());

                if (GarageManage.ReChargeVehicle(License_plate, Amount_of_minutes_to_charge))
                {
                    Console.WriteLine("Success Vehicle Recharged!");
                    Console.WriteLine("Amount of hours left to work after Recharge:{0}", GarageManage.GetCurrentAmountOfEnergy(License_plate));
                }
                else
                {
                    WrongAmountInput();
                    BackToMain();
                }
            }
            else
            {
                Console.WriteLine("There is no such car /or car isnt Electric type.");
                BackToMain();
            }
            
        }
        public void PresentFullInfoMenu()//7
        {
            Console.WriteLine("To present full info of vehicle:");
            Console.WriteLine("Enter license plate:");
            string License_plate = GarageManage.CheckVehicleInGarage(GetFromUserLicensePlate());

            if (License_plate!=null)
            {
                //get all info functions
                var vehicle = GarageManage.TargetVehicleInfo(License_plate);
                InformationSorter(vehicle);
            }
            else
            {
                Console.WriteLine("There is no such car.");
                BackToMain();
            }
        }
        public void InformationSorter(Vehicle vehicle) {
            string License_P=vehicle.GetLicensePlate();
            Vehicle.VehicleType vhicle_T = vehicle.GetTypeOfVehicle();
            Console.WriteLine("============================================================");
            Console.WriteLine("Vehicle Full Information:");
            Console.WriteLine("Vehicle License Plate:{0}", License_P);
            Console.WriteLine("Vehicle Type:{0}", vhicle_T);
            if (vhicle_T == (Vehicle.VehicleType)1) {

                AmountCarDoors amount_ocd=vehicle.GetAmountOfDoors();
                Color c=vehicle.GetColor();
                Console.WriteLine("Amount of doors: {0}", amount_ocd);
                Console.WriteLine("Color: {0}",c);
            }
            if (vhicle_T == (Vehicle.VehicleType)2) {

                bool is_carring_Dangerous_Subs=vehicle.GetDangerousSubstance();
                float Max_Cargo_Weight=vehicle.GetMaxCargoWeight();

                Console.WriteLine("Is carring dangerous Substance: {0}", is_carring_Dangerous_Subs);
                Console.WriteLine("Max cargo weight: {0}", Max_Cargo_Weight);
            }
            if (vhicle_T == (Vehicle.VehicleType)3){
                int Engine_V=vehicle.GetEngineVolume();
                LicenseType License_T= vehicle.GetLicenseType();

                Console.WriteLine("Engine volume: {0}", Engine_V);
                Console.WriteLine("License type: {0}", License_T);
            }
            Console.WriteLine("Model: {0}", vehicle.GetModel());
            Console.WriteLine("Current PSI: {0}", vehicle.GetCurrentPSI());
            

            if (vehicle.GetEngineType() == (Engine)1)
            {
                float Current_Amount_Of_E=vehicle.GetCurrentAmountOfEnergy();
                Console.WriteLine("Engine Type: {0}", vehicle.GetEngineType());
                Console.WriteLine("Current amount of energy: {0}", Current_Amount_Of_E);
                

            }
            if (vehicle.GetEngineType() == (Engine)2)
            {
                float Current_Amount_Of_F=vehicle.GetCurrentAmountOfFuel();
                GasType Gas_T= vehicle.GetGasType();
                Console.WriteLine("Engine Type: {0}", vehicle.GetEngineType());
                Console.WriteLine("Current amount of Fuel: {0}", Current_Amount_Of_F);
                Console.WriteLine("Fuel Type: {0}", Gas_T);
            }
            int tires=vehicle.typeOfTire;
            if (tires == 1)
            {
                Console.WriteLine("Type of tires:{0} Manufacturer is: Michelin ", tires);
            }
            if (tires == 2)
            {
                Console.WriteLine("Type of tires:{0} Manufacturer is: Pirelli ", tires);
            }
            if (tires == 3)
            {
                Console.WriteLine("Type of tires:{0} Manufacturer is: Dunlop", tires);
            }
            if (tires == 4)
            {
                Console.WriteLine("Type of tires:{0} Manufacturer is: GoodYear ", tires);
            }
            if (tires == 5)
            {
                Console.WriteLine("Type of tires:{0} Manufacturer is: Kumho ", tires);
            }
            if (tires == 6)
            {
                Console.WriteLine("Type of tires:{0} Manufacturer is: Hankook ", tires);
            }

            Console.WriteLine("============================================================");
         
        }
    }
}