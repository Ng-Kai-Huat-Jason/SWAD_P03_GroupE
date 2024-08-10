using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_ReturnVehicle_UseCase
{
    public class AccidentReport
    {
        public string ReportID { get; set; }
        public DateTime AccidentDateTime { get; set; }
        public string AccidentDesc { get; set; }
        public string AccidentLocation { get; set; }

        public AccidentReport(){}

        public AccidentReport(string reportID, DateTime accidentDateTime, string accidentDescription, string accidentLocation)
        {
            this.ReportID = reportID;
            this.AccidentDateTime = accidentDateTime;
            this.AccidentDesc = accidentDescription;
            this.AccidentLocation = accidentLocation;
        }


        // Implemented by Liang Ding Xuan, S10258272, Use Case : Return Vehicle 
        public AccidentReport ReportAccident(string damages, string location, DateTime datetime)
        {
            Random r = new Random();
            int rInt = r.Next(0, 100);
            return new AccidentReport(rInt.ToString(), datetime, damages, location);
        }
    }

}
