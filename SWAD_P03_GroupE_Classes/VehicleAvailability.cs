using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class VehicleAvailability
    {
        public string AvailabilityID { get; set; }
        public List<AvailabilitySlot> AvailabilitySlots { get; set; }

        // Constructor for VehicleAvailability class
        public VehicleAvailability(string availabilityID, List<AvailabilitySlot> availabilitySlots)
        {
            AvailabilityID = availabilityID;
            AvailabilitySlots = availabilitySlots;
        }

        public static VehicleAvailability CreateVehicleAvailability()
        {
            // Generate a new GUID 
            string availabilityID = Guid.NewGuid().ToString();

            // Create an empty list of AvailabilitySlot
            var availabilitySlots = new List<AvailabilitySlot>();

            return new VehicleAvailability(availabilityID, availabilitySlots);
        }

        public void AddAvailabilitySlot(AvailabilitySlot slot)
        {
            if (slot != null && slot.ValidateAvailabilitySlot())
            {
                AvailabilitySlots.Add(slot);
                Console.WriteLine("Availability slot added.");
            }
            else
            {
                Console.WriteLine("Invalid availability slot.");
            }
        }

        public void DisplayAvailabilityInformation()
        {
            Console.WriteLine("Vehicle Availability Information:");
            Console.WriteLine($"Availability ID: {AvailabilityID}");
            Console.WriteLine("Availability Slots:");
            foreach (var slot in AvailabilitySlots)
            {
                Console.WriteLine($"  Slot ID: {slot.AvailabilitySlotID}");
                Console.WriteLine($"  Start Time: {slot.StartTime}");
                Console.WriteLine($"  End Time: {slot.EndTime}");
            }
        }
        public bool CheckAvailability(List<VehicleAvailability> availabilites, DateTime startDateTime, DateTime endDateTime)
        {
            return true;
            // Function Implemented by Tan Guo Zhi Kelvin, S10262567, Use Case : Book Vehicle
        }

        public bool ValidateAvailabilitySlot(DateTime startDateTime, DateTime endDateTime)
        {
            return true;

        }
    }
}
