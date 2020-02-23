using System.Collections.Generic;

namespace Garage.GeneralLogic
{
    public class Tire
    {
        string Manufacturer;
        float CurrentPSI;
        float MaxPSI;
        int barcode;

        public Tire(string manu, float maxPSI,int barcodeVal)
        {
            Manufacturer = manu;
            MaxPSI = maxPSI;
            barcode = barcodeVal;
        }
        public int GetBarcode() {
            return barcode;
        }
        public string GetManufacturer() {
            return Manufacturer;
        }
        bool InflateFunction(float AirAmount)
        {
            return true;
        }

    }
}
