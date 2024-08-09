using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class AvailabilitySlot
    {
        public string AvailabilitySlotID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public AvailabilitySlot() { }

        // Constructor for AvailabilitySlot class
        public AvailabilitySlot(string availabilitySlotID, DateTime startTime, DateTime endTime)
        {
            AvailabilitySlotID = availabilitySlotID;
            StartTime = startTime;
            EndTime = endTime;
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public static AvailabilitySlot CreateAvailabilitySlot()
        {
            Console.Write("Enter Start Time (yyyy-mm-dd hh:mm): ");
            DateTime startTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter End Time (yyyy-mm-dd hh:mm): ");
            DateTime endTime = DateTime.Parse(Console.ReadLine());

            return new AvailabilitySlot(Guid.NewGuid().ToString(), startTime, endTime);
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public bool ValidateAvailabilitySlot()
        {
            DateTime currentTime = DateTime.Now;

            // Check if start time is before end time
            if (StartTime >= EndTime)
            {
                Console.WriteLine("Invalid slot: Start time must be before end time.");
                return false;
            }

            // Check if start time is at least 24 hours from now
            if (StartTime <= currentTime.AddHours(24))
            {
                Console.WriteLine("Invalid slot: Start time must be at least 24 hours from now.");
                return false;
            }

            return true;
        }
    }
}
