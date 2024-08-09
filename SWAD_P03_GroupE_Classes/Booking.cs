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
            PickUpLocation = pickUpLocation;
            ReturnLocation = returnLocation;
        }
        public string GetDetails()
        {
            return string.Empty;
            // Function Implemented by Liang Ding Xuan, S10258272, Use Case : Return Vehicle 
        }

        public void SetLocation(Location location)
        {
           // Function Implemented by Liang Ding Xuan, S10258272, Use Case : Return Vehicle 
        }

        public void Return()
        {
            // Function Implemented by Liang Ding Xuan, S10258272, Use Case : Return Vehicle 
        }
    }
}
