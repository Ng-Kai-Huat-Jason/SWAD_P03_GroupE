using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    // This class is not utilised for use case, only kept here for parity with other use cases
    public class Booking
    {
        public string BookingID { get; set; }
        public DateTime BookingDateTime { get; set; }
        public string BookingStatus { get; set; }
        public float PenaltyFee { get; set; }
        public float RentalFee { get; set; }
        public AvailabilitySlot BookedAvailabilitySlot { get; set; }
        public Vehicle Vehicle { get; set; }
        public Reviews Reviews { get; set; }

        public Payment Payment { get; set; }
        public Location PickUpLocation { get; set; }
        public Location ReturnLocation { get; set; }
        public Booking() {}

        // Constructor for Booking class
        public Booking(string bookingID, DateTime bookingDateTime, string bookingStatus,
                       float penaltyFee, float rentalFee, AvailabilitySlot bookedAvailabilitySlot,
                       Location pickUpLocation, Location returnLocation)
        {
            BookingID = bookingID;
            BookingDateTime = bookingDateTime;
            BookingStatus = bookingStatus;
            PenaltyFee = penaltyFee;
            RentalFee = rentalFee;
            BookedAvailabilitySlot = bookedAvailabilitySlot;
            Vehicle = null; // Set to null, not in params
            Reviews = null; // Set to null, not in params
            Payment = null; // Set to null, not in params
            PickUpLocation = pickUpLocation;
            ReturnLocation = returnLocation;
        }


        public Booking(string bookingID, DateTime bookingDate, Vehicle vehicle, string bookingStatus, float penaltyFee, float rentalFee, AvailabilitySlot availabilitySlot)
        {
            BookingID = bookingID;
            BookingDateTime = bookingDate;
            Vehicle = vehicle;
            BookingStatus = bookingStatus;
            PenaltyFee = penaltyFee;
            RentalFee = rentalFee;
            BookedAvailabilitySlot = availabilitySlot;
            Payment = null;
            Reviews = null; 
            PickUpLocation = null; 
            ReturnLocation = null; 
        }

        // Implemented by Liang Ding Xuan, S10258272, Use Case : Return Vehicle 
        public void SetReturnLocation(Location location)
        {
            ReturnLocation = location;
        }

        // Implemented by Liang Ding Xuan, S10258272, Use Case : Return Vehicle 
        public string GetDetails()
        {
            return $"BookingID: {BookingID}, \n " +
                $"Booking Date: {BookingDateTime}, " +
                $"\n Vehicle: {Vehicle.Make} {Vehicle.Model}, " +
                $"\n Booking Status: {BookingStatus}, " +
                $"\n Availability Slot: {BookedAvailabilitySlot.StartTime} - {BookedAvailabilitySlot.EndTime}, " +
                $"\n Rental Fee: {RentalFee}, " +
                $"\n Penalty Fee: {PenaltyFee}";
        }

        // Implemented by Liang Ding Xuan, S10258272, Use Case : Return Vehicle 
        public void ReturnVehicle()
        {
            BookingStatus = "Completed";
        }
    }
}
