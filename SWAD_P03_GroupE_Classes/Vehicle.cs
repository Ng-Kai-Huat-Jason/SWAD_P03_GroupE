using System.Text.RegularExpressions;

namespace SWAD_P03_GroupE_Classes
{
    public class Vehicle
    {
        public string VehicleID { get; set; }
        public string VehicleRegNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public float RentalRate { get; set; }
        public int MaxSeatingCapacity { get; set; }
        public int Year { get; set; }
        public float Mileage { get; set; }
        public bool IsVerified { get; set; }
        public FuelType FuelType { get; set; }
        public Insurance InsuranceDetails { get; set; }
        public VehicleAvailability Availability { get; set; }
        public List<Photo> Photos { get; set; }
        public List<Reviews> Reviews { get; set; }
        public List<InspectionReport> InspectionReports { get; set; }

        public List<Booking> BookingsList { get; set; }
        public Vehicle()
        {
            VehicleID = Guid.NewGuid().ToString(); // Global UID
            VehicleRegNo = string.Empty;
            Make = string.Empty;
            Model = string.Empty;
            RentalRate = 0;
            MaxSeatingCapacity = 0;
            Year = 0;
            Mileage = 0;
            IsVerified = false; // Default value
            FuelType = null; // Default value
            InsuranceDetails = null; // Null or default value
            Availability = null; // Null or default value
            Photos = new List<Photo>(); // Initialize to an empty list
            InspectionReports = new List<InspectionReport>(); // Initialize to an empty list
            BookingsList = new List<Booking>();
        }

        public Vehicle(string vehicleRegNo, string make, string model, float rentalRate, int maxSeatingCapacity, int year, float mileage)
        {
            VehicleID = Guid.NewGuid().ToString(); // Global UID
            VehicleRegNo = vehicleRegNo;
            Make = make;
            Model = model;
            RentalRate = rentalRate;
            MaxSeatingCapacity = maxSeatingCapacity;
            Year = year;
            Mileage = mileage;
            IsVerified = false; // Default value
            FuelType = null; // Default value
            InsuranceDetails = null; // Null or default value
            Availability = null; // Null or default value
            Photos = new List<Photo>(); // Initialize to an empty list
            BookingsList = new List<Booking>();
        }


        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public static Vehicle CreateVehicle()
        {
            string input;
            // Gather parameters for the vehicle
            string vehicleRegNo = null;
            string make = null;
            string model = null;
            float rentalRate = 0;
            int maxSeatingCapacity = 0;
            int year = 0;
            float mileage = 0;

            while (true)
            {
                // Vehicle Registration Number
                Console.Write("Enter Vehicle Registration Number (0 to cancel): ");
                input = Console.ReadLine();
                if (input == "0") return null;
                if (!string.IsNullOrWhiteSpace(input))
                {
                    vehicleRegNo = input;
                    break;
                }
                Console.WriteLine("Vehicle Registration Number cannot be empty.");
            }

            while (true)
            {
                // Make
                Console.Write("Enter Make (0 to cancel): ");
                input = Console.ReadLine();
                if (input == "0") return null;
                if (!string.IsNullOrWhiteSpace(input))
                {
                    make = input;
                    break;
                }
                Console.WriteLine("Make cannot be empty.");
            }

            while (true)
            {
                // Model
                Console.Write("Enter Model (0 to cancel): ");
                input = Console.ReadLine();
                if (input == "0") return null;
                if (!string.IsNullOrWhiteSpace(input))
                {
                    model = input;
                    break;
                }
                Console.WriteLine("Model cannot be empty.");
            }

            while (true)
            {
                // Rental Rate
                Console.Write("Enter Rental Rate (0 to cancel): ");
                input = Console.ReadLine();
                if (input == "0") return null;
                if (float.TryParse(input, out float parsedRentalRate) && parsedRentalRate >= 0)
                {
                    rentalRate = parsedRentalRate;
                    break;
                }
                Console.WriteLine("Invalid Rental Rate.");
            }

            while (true)
            {
                // Maximum Seating Capacity
                Console.Write("Enter Maximum Seating Capacity (0 to cancel): ");
                input = Console.ReadLine();
                if (input == "0") return null;
                if (int.TryParse(input, out int parsedMaxSeatingCapacity) && parsedMaxSeatingCapacity >= 1)
                {
                    maxSeatingCapacity = parsedMaxSeatingCapacity;
                    break;
                }
                Console.WriteLine("Invalid Maximum Seating Capacity.");
            }

            while (true)
            {
                // Year
                Console.Write("Enter Year (YYYY) (0 to cancel): ");
                input = Console.ReadLine();
                if (input == "0") return null;
                if (int.TryParse(input, out int parsedYear) && parsedYear >= 1886 && parsedYear <= DateTime.Now.Year)
                {
                    year = parsedYear;
                    break;
                }
                Console.WriteLine("Invalid Year.");
            }

            while (true)
            {
                // Mileage
                Console.Write("Enter Mileage (km) (0 to cancel): ");
                input = Console.ReadLine();
                if (input == "0") return null;
                if (float.TryParse(input, out float parsedMileage) && parsedMileage >= 0)
                {
                    mileage = parsedMileage;
                    break;
                }
                Console.WriteLine("Invalid Mileage.");
            }

            // Create the vehicle using the parameterized constructor
            Vehicle vehicle = new Vehicle(vehicleRegNo, make, model, rentalRate, maxSeatingCapacity, year, mileage);

            return vehicle;
        }


        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void AddFuelType()
        {
            FuelType fuelType = null;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Select Fuel Type (1 for Gas, 2 for Electric, 3 for Hybrid): ");
                string input = Console.ReadLine();
                // Represent for ALT frame in sequence diagram
                switch (input)
                {
                    case "1":
                        fuelType = new Gas("", "", 0f); // Provide default values 
                        isValidInput = true;
                        break;

                    case "2":
                        fuelType = new Electric("", "", 0f, 0f); // Provide default values
                        isValidInput = true;
                        break;

                    case "3":
                        fuelType = new Hybrid("", "", 0f, "", "", 0f, 0f); // Provide default values
                        isValidInput = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select 1, 2, or 3.");
                        break;
                }
            }

            // Create the FuelType details,this is 4.1.1.1, 5.1, 6.1 in Sequence Diagram
            fuelType.CreateFuelType();

            // Set the FuelType for the vehicle, this is 4.1.1.2, 5.2, 6.2 in Sequence Diagram
            SetFuelType(fuelType);
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        // Method to set FuelType, this is 4.1.1.2, 5.2, 6.2 in Sequence Diagram
        public void SetFuelType(FuelType fuelType)
        {
            FuelType = fuelType;
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public bool ValidateVehicle()
        {
            // Validate Vehicle Registration Number
            string regNoPattern = @"^[A-Z]{3}\d{4}[A-Z]$";
            if (!Regex.IsMatch(VehicleRegNo, regNoPattern))
            {
                Console.WriteLine("Invalid Vehicle Registration Number.");
                return false;
            }

            // Additional validations
            if (string.IsNullOrWhiteSpace(Make))
            {
                Console.WriteLine("Make cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Model))
            {
                Console.WriteLine("Model cannot be empty.");
                return false;
            }

            if (RentalRate <= 0)
            {
                Console.WriteLine("Rental Rate must be greater than zero.");
                return false;
            }

            if (MaxSeatingCapacity < 1)
            {
                Console.WriteLine("Maximum Seating Capacity must be at least 1.");
                return false;
            }

            if (Year < 1886 || Year > DateTime.Now.Year)
            {
                Console.WriteLine("Year must be between 1886 and the current year.");
                return false;
            }

            if (Mileage < 0)
            {
                Console.WriteLine("Mileage must be a non-negative value.");
                return false;
            }
            // Validate FuelType properties
            if (FuelType != null)
            {
                if (FuelType is Gas gas)
                {
                    if (string.IsNullOrWhiteSpace(gas.PreferredPetrolKiosk))
                    {
                        Console.WriteLine("Preferred Petrol Kiosk cannot be empty for Gas vehicles.");
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(gas.PetrolType))
                    {
                        Console.WriteLine("Petrol Type cannot be empty for Gas vehicles.");
                        return false;
                    }
                    if (gas.VehicleMaxFuelCapacity <= 0)
                    {
                        Console.WriteLine("Vehicle Max Fuel Capacity must be greater than zero for Gas vehicles.");
                        return false;
                    }
                }
                else if (FuelType is Electric electric)
                {
                    if (string.IsNullOrWhiteSpace(electric.PreferredChargingStation))
                    {
                        Console.WriteLine("Preferred Charging Station cannot be empty for Electric vehicles.");
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(electric.VehicleCurrentType) ||
                        (electric.VehicleCurrentType != "Alternate" && electric.VehicleCurrentType != "Direct"))
                    {
                        Console.WriteLine("Vehicle Current Type must be either 'Alternate' or 'Direct' for Electric vehicles.");
                        return false;
                    }
                    if (electric.VehicleChargingRate <= 0)
                    {
                        Console.WriteLine("Vehicle Charging Rate must be greater than zero for Electric vehicles.");
                        return false;
                    }
                    if (electric.VehicleMaxChargeCapacity <= 0)
                    {
                        Console.WriteLine("Vehicle Max Charge Capacity must be greater than zero for Electric vehicles.");
                        return false;
                    }
                }
                else if (FuelType is Hybrid hybrid)
                {
                    if (string.IsNullOrWhiteSpace(hybrid.PreferredPetrolKiosk))
                    {
                        Console.WriteLine("Preferred Petrol Kiosk cannot be empty for Hybrid vehicles.");
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(hybrid.PetrolType))
                    {
                        Console.WriteLine("Petrol Type cannot be empty for Hybrid vehicles.");
                        return false;
                    }
                    if (hybrid.VehicleMaxFuelCapacity <= 0)
                    {
                        Console.WriteLine("Vehicle Max Fuel Capacity must be greater than zero for Hybrid vehicles.");
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(hybrid.PreferredChargingStation))
                    {
                        Console.WriteLine("Preferred Charging Station cannot be empty for Hybrid vehicles.");
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(hybrid.VehicleCurrentType) ||
                        (hybrid.VehicleCurrentType != "Alternate" && hybrid.VehicleCurrentType != "Direct"))
                    {
                        Console.WriteLine("Vehicle Current Type must be either 'Alternate' or 'Direct' for Hybrid vehicles.");
                        return false;
                    }
                    if (hybrid.VehicleChargingRate <= 0)
                    {
                        Console.WriteLine("Vehicle Charging Rate must be greater than zero for Hybrid vehicles.");
                        return false;
                    }
                    if (hybrid.VehicleMaxChargeCapacity <= 0)
                    {
                        Console.WriteLine("Vehicle Max Charge Capacity must be greater than zero for Hybrid vehicles.");
                        return false;
                    }
                }
            }
            return true;
        }
        

        public static bool ValidateBookedVehicle(List<Vehicle> vehicles,
                                          List<VehicleAvailability> vehicleAvailabilities,
                                          string brand,
                                          string model,
                                          DateTime startDateTime,
                                          DateTime endDateTime,
                                          out Vehicle selectedVehicle)
        {
            selectedVehicle = null;
            return false;
            // Function Implemented by Tan Guo Zhi Kelvin, S10262567, Use Case : Book Vehicle
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void AddPhoto(Photo photo)
        {
            if (photo != null)
            {
                Photos.Add(photo);
                Console.WriteLine("Photo added successfully.");
            }
            else
            {
                Console.WriteLine("Cannot add null photo.");
            }
        }


        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void AddInsurance(Insurance insurance)
        {
            if (insurance != null)
            {
                InsuranceDetails = insurance;
            }
        }


        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void AddVehicleAvailability (VehicleAvailability vehicleAvailability)
        {
            if (vehicleAvailability != null)
            {
                Availability = vehicleAvailability;
            }
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void DisplayVehicleInformation()
        {
            Console.WriteLine("Vehicle Information:");
            Console.WriteLine($"Vehicle ID: {VehicleID}");
            Console.WriteLine($"Registration Number: {VehicleRegNo}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Rental Rate: ${RentalRate} per hour" );
            Console.WriteLine($"Max Seating Capacity: {MaxSeatingCapacity}");
            Console.WriteLine($"Year: {Year} of manafacture");
            Console.WriteLine($"Mileage: {Mileage} km");

            // Display Fuel Type Information
            FuelType?.DisplayFuelTypeInformation();

            // Display Insurance Details
            InsuranceDetails?.DisplayInsuranceInformation();

            // Display Availability Information
            Availability?.DisplayAvailabilityInformation();

            // Display Photos
            Console.WriteLine("Photos:");
            foreach (var photo in Photos)
            {
                Console.WriteLine($"  Photo ID: {photo.PhotoID}");
            }
        }
    }
}



