using System;
using System.Collections.Generic;
using System.Linq;

namespace SWAD_P03_GroupE_Classes
{
    public abstract class User
    {
        public string UserID { get; set; }
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; } 
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime DateJoin { get; set; }

        protected User()
        {
        }

        // Constructor
        public User(string userID, string fullName, string contactNumber, DateTime dateOfBirth,
                    string address, string zipcode, string emailAddress, string password, DateTime dateJoin)
        {
            UserID = userID;
            FullName = fullName;
            ContactNumber = contactNumber;
            DateOfBirth = dateOfBirth;
            Address = address;
            Zipcode = zipcode; 
            EmailAddress = emailAddress;
            Password = password;
            DateJoin = dateJoin;
        }



        public User RetrieveUser()
        {
            return this;
        }

        // Abstract method to display User information
        public abstract User DisplayUserInfo();
    }

    public class CarOwner : User
    {
        public float ProjectedMonthlyRevenue { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public CarOwner() { }

        // Constructor
        public CarOwner(string userID, string fullName, string contactNumber, DateTime dateOfBirth,
                        string address, string zipcode, string emailAddress, string password, DateTime dateJoin)
            : base(userID, fullName, contactNumber, dateOfBirth, address, zipcode, emailAddress, password, dateJoin)
        {
            ProjectedMonthlyRevenue = 0;
            Vehicles = new List<Vehicle>();
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void RegisterAVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            Console.WriteLine("Vehicle registered successfully!");
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void DisplayAllVehicleInformation()
        {
            if (Vehicles.Count == 0)
            {
                Console.WriteLine("No vehicles registered.");
                return;
            }
            foreach (var vehicle in Vehicles)
            {
                vehicle.DisplayVehicleInformation();
            }
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void DisplayVehicleById(string vehicleId)
        {
            var vehicle = Vehicles.FirstOrDefault(v => v.VehicleID == vehicleId);
            if (vehicle != null)
            {
                vehicle.DisplayVehicleInformation();
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public override User DisplayUserInfo()
        {
            Console.WriteLine("Car Owner Information:");
            Console.WriteLine($"User ID: {UserID}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Contact Number: {ContactNumber}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Zipcode: {Zipcode}");
            Console.WriteLine($"Email Address: {EmailAddress}");
            Console.WriteLine($"Date Joined: {DateJoin.ToShortDateString()}");
            Console.WriteLine($"Projected Monthly Revenue: {ProjectedMonthlyRevenue}");
            return this;
        }
    }

    public class Admin : User
    {
        public string Role { get; set; }

        public Admin() { }

        // Constructor
        public Admin(string userID, string fullName, string contactNumber, DateTime dateOfBirth,
                     string address, string zipcode, string emailAddress, string password, DateTime dateJoin, string role)
            : base(userID, fullName, contactNumber, dateOfBirth, address, zipcode, emailAddress, password, dateJoin)
        {
            Role = role;
        }

        public void VerifyRenter(Renter renter)
        {
            // Not necessary for my function
        }

        // Override the DisplayUserInfo method
        public override User DisplayUserInfo()
        {
            Console.WriteLine("Admin Information:");
            Console.WriteLine($"User ID: {UserID}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Contact Number: {ContactNumber}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Zipcode: {Zipcode}");
            Console.WriteLine($"Email Address: {EmailAddress}");
            Console.WriteLine($"Date Joined: {DateJoin.ToShortDateString()}");
            Console.WriteLine($"Role: {Role}");
            return this;
        }
    }

    public class Renter : User
    {
        public string RenterType { get; set; }
        public string BackgroundCheckStatus { get; set; }
        public string RegistrationStatus { get; set; }
        public bool VerificationEmailSent { get; set; }
        public string VerificationStatus { get; set; }
        public List<Booking> BookingsList { get; set; }
        public DriverLicence DriverLicence { get; set; }

        public Renter() { }

        // Constructor
        public Renter(string userID, string fullName, string contactNumber, DateTime dateOfBirth,
                      string address, string zipcode, string emailAddress, string password, DateTime dateJoin,
                      string renterType, string backgroundCheckStatus, string registrationStatus,
                      bool verificationEmailSent, string verificationStatus)
            : base(userID, fullName, contactNumber, dateOfBirth, address, zipcode, emailAddress, password, dateJoin)
        {
            RenterType = renterType;
            BackgroundCheckStatus = backgroundCheckStatus;
            RegistrationStatus = registrationStatus;
            VerificationEmailSent = verificationEmailSent;
            VerificationStatus = verificationStatus;
            BookingsList = new List<Booking>();
            DriverLicence = null;
        }

        public List<Booking> RetrieveBookings()
        {
            return BookingsList;
        }

        // Function Implemented by Liang Ding Xuan, S10258272, Use Case: Return Vehicle 
        public void CompleteBooking(Booking booking)
        {
            BookingsList.Remove(booking);
        }

        // Override the DisplayUserInfo method
        public override User DisplayUserInfo()
        {
            Console.WriteLine("Renter Information:");
            Console.WriteLine($"User ID: {UserID}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Contact Number: {ContactNumber}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Zipcode: {Zipcode}");
            Console.WriteLine($"Email Address: {EmailAddress}");
            Console.WriteLine($"Date Joined: {DateJoin.ToShortDateString()}");
            Console.WriteLine($"Renter Type: {RenterType}");
            Console.WriteLine($"Background Check Status: {BackgroundCheckStatus}");
            Console.WriteLine($"Registration Status: {RegistrationStatus}");
            Console.WriteLine($"Verification Email Sent: {VerificationEmailSent}");
            Console.WriteLine($"Verification Status: {VerificationStatus}");
            return this;
        }


        // Implemented by Ng Kai Huat Jason, S10262552, Use Case : Register as Renter
        public static Renter CreateRenter(string fullName, string contactNumber, DateTime dateOfBirth, string address, string zipcode, string emailAddress, string password, string renterType)
        {
            return new Renter(
                userID: Guid.NewGuid().ToString(),
                fullName: fullName,
                contactNumber: contactNumber,
                dateOfBirth: dateOfBirth,
                address: address,
                zipcode: zipcode,
                emailAddress: emailAddress,
                password: password,
                dateJoin: DateTime.Now,
                renterType: renterType,
                backgroundCheckStatus: "Pending",
                registrationStatus: "Pending",
                verificationEmailSent: false,
                verificationStatus: "Unverified"
            );
        }

        // Implemented by Ng Kai Huat Jason, S10262552, Use Case : Register as Renter
        public void addLicenceToRenter(DriverLicence aLicence)
        {
            DriverLicence = aLicence;
        }

    }
}
