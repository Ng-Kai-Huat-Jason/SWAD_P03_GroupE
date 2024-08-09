using System;

namespace SWAD_P03_GroupE_Classes
{
    public abstract class FuelType
    {
        public abstract void DisplayFuelTypeInformation();
        public abstract void CreateFuelType();
    }

    public class Gas : FuelType
    {
        public string PreferredPetrolKiosk { get; set; }
        public string PetrolType { get; set; }
        public float VehicleMaxFuelCapacity { get; set; }

        // Constructor
        public Gas(string preferredPetrolKiosk, string petrolType, float vehicleMaxFuelCapacity)
        {
            PreferredPetrolKiosk = preferredPetrolKiosk;
            PetrolType = petrolType;
            VehicleMaxFuelCapacity = vehicleMaxFuelCapacity;
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public override void DisplayFuelTypeInformation()
        {
            Console.WriteLine("Fuel Type: Gas");
            Console.WriteLine($"Preferred Petrol Kiosk: {PreferredPetrolKiosk}");
            Console.WriteLine($"Petrol Type: {PetrolType}");
            Console.WriteLine($"Vehicle Max Fuel Capacity: {VehicleMaxFuelCapacity} liters");
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public override void CreateFuelType()
        {
            Console.WriteLine("Enter Preferred Petrol Kiosk:");
            PreferredPetrolKiosk = Console.ReadLine();

            Console.WriteLine("Enter Petrol Type:");
            PetrolType = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Max Fuel Capacity (liters):");
            VehicleMaxFuelCapacity = float.Parse(Console.ReadLine());
        }
    }

    public class Electric : FuelType
    {
        public string PreferredChargingStation { get; set; }
        public string VehicleCurrentType { get; set; }
        public float VehicleChargingRate { get; set; }
        public float VehicleMaxChargeCapacity { get; set; }

        // Constructor
        public Electric(string preferredChargingStation, string vehicleCurrentType, float vehicleChargingRate, float vehicleMaxChargeCapacity)
        {
            PreferredChargingStation = preferredChargingStation;
            VehicleCurrentType = vehicleCurrentType;
            VehicleChargingRate = vehicleChargingRate;
            VehicleMaxChargeCapacity = vehicleMaxChargeCapacity;
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public override void DisplayFuelTypeInformation()
        {
            Console.WriteLine("Fuel Type: Electric");
            Console.WriteLine($"Preferred Charging Station: {PreferredChargingStation}");
            Console.WriteLine($"Vehicle Current Type: {VehicleCurrentType}");
            Console.WriteLine($"Vehicle Charging Rate: {VehicleChargingRate} kW");
            Console.WriteLine($"Vehicle Max Charge Capacity: {VehicleMaxChargeCapacity} kWh");
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public override void CreateFuelType()
        {
            Console.WriteLine("Enter Preferred Charging Station:");
            PreferredChargingStation = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Current Type:");
            VehicleCurrentType = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Charging Rate (kW):");
            VehicleChargingRate = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Vehicle Max Charge Capacity (kWh):");
            VehicleMaxChargeCapacity = float.Parse(Console.ReadLine());
        }
    }

    public class Hybrid : FuelType
    {
        public string PreferredPetrolKiosk { get; set; }
        public string PetrolType { get; set; }
        public float VehicleMaxFuelCapacity { get; set; }
        public string PreferredChargingStation { get; set; }
        public string VehicleCurrentType { get; set; }
        public float VehicleChargingRate { get; set; }
        public float VehicleMaxChargeCapacity { get; set; }

        // Constructor
        public Hybrid(string preferredPetrolKiosk, string petrolType, float vehicleMaxFuelCapacity,
                      string preferredChargingStation, string vehicleCurrentType,
                      float vehicleChargingRate, float vehicleMaxChargeCapacity)
        {
            PreferredPetrolKiosk = preferredPetrolKiosk;
            PetrolType = petrolType;
            VehicleMaxFuelCapacity = vehicleMaxFuelCapacity;
            PreferredChargingStation = preferredChargingStation;
            VehicleCurrentType = vehicleCurrentType;
            VehicleChargingRate = vehicleChargingRate;
            VehicleMaxChargeCapacity = vehicleMaxChargeCapacity;
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public override void DisplayFuelTypeInformation()
        {
            Console.WriteLine("Fuel Type: Hybrid");
            Console.WriteLine($"Preferred Petrol Kiosk: {PreferredPetrolKiosk}");
            Console.WriteLine($"Petrol Type: {PetrolType}");
            Console.WriteLine($"Vehicle Max Fuel Capacity: {VehicleMaxFuelCapacity} liters");
            Console.WriteLine($"Preferred Charging Station: {PreferredChargingStation}");
            Console.WriteLine($"Vehicle Current Type (Alternate or Direct): {VehicleCurrentType}");
            Console.WriteLine($"Vehicle Charging Rate: {VehicleChargingRate} kW");
            Console.WriteLine($"Vehicle Max Charge Capacity: {VehicleMaxChargeCapacity} kWh");
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public override void CreateFuelType()
        {
            Console.WriteLine("Enter Preferred Petrol Kiosk:");
            PreferredPetrolKiosk = Console.ReadLine();

            Console.WriteLine("Enter Petrol Type:");
            PetrolType = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Max Fuel Capacity (liters):");
            VehicleMaxFuelCapacity = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Preferred Charging Station:");
            PreferredChargingStation = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Current Type:");
            VehicleCurrentType = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Charging Rate (kW):");
            VehicleChargingRate = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Vehicle Max Charge Capacity (kWh):");
            VehicleMaxChargeCapacity = float.Parse(Console.ReadLine());
        }
    }
}
