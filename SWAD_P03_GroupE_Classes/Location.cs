using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    // This class is not utilised for my use case "Register Vehicle as Car Owner"
    public abstract class Location
    {
        public string Address { get; set; }
        public DateTime PickUpDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }

        protected Location() { }

        // Constructor for Location class
        protected Location(string address, DateTime pickUpDateTime, DateTime returnDateTime)
        {
            Address = address;
            PickUpDateTime = pickUpDateTime;
            ReturnDateTime = returnDateTime;
        }
        public class iCarStation : Location
        {
            public string StationID { get; set; }
            public string StationName { get; set; }
            public string OperatingHrs { get; set; }
            public string ContactInfo { get; set; }

            // Constructor for iCarStation class
            public iCarStation(string address, DateTime pickUpDateTime, DateTime returnDateTime,
                               string stationID, string stationName, string operatingHrs, string contactInfo)
                : base(address, pickUpDateTime, returnDateTime)
            {
                StationID = stationID;
                StationName = stationName;
                OperatingHrs = operatingHrs;
                ContactInfo = contactInfo;
            }
            public string GetLocation()
            {
                return string.Empty;
                // Function Implemented by Liang Ding Xuan, S10258272, Use Case : Return Vehicle 
            }

            public bool ValidatePickUpLocation()
            {
                return true;
                // Function Implemented by Tan Guo Zhi Kelvin, S10262567, Use Case : Book Vehicle
            }
        }

        public class DeliveryService : Location
        {
            public string DeliveryID { get; set; }
            public DateTime DeliveryDateTime { get; set; }
            public float DeliveryFee { get; set; }
            public string DeliveryStatus { get; set; }

            // Constructor for DeliveryService class
            public DeliveryService(string address, DateTime pickUpDateTime, DateTime returnDateTime,
                                   string deliveryID, DateTime deliveryDateTime, float deliveryFee, string deliveryStatus)
                : base(address, pickUpDateTime, returnDateTime)
            {
                DeliveryID = deliveryID;
                DeliveryDateTime = deliveryDateTime;
                DeliveryFee = deliveryFee;
                DeliveryStatus = deliveryStatus;
            }

            public static void RecordDeliveryDetails (List<DeliveryService> deliveries, string address, DateTime deliveryDateTime)
            {
                // Function Implemented by Tan Guo Zhi Kelvin, S10262567, Use Case : Book Vehicle
            }
        }
    }
}
