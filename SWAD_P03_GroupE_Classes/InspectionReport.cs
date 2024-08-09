using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class InspectionReport
    {
        public string inspectionID { get; set; }
        public string reportDetails { get; set; }
        public DateTime inspectionDateTime { get; set; }
        public string inspectorName { get; set; }
        public string status { get; set; }

        public InspectionReport(){}

        public InspectionReport(string InspectionID, string ReportDetails, DateTime InspectionDateTime, string InspectorName, string Status)
        {
            inspectionID = InspectionID;
            reportDetails = ReportDetails;
            inspectionDateTime = InspectionDateTime;
            inspectorName = InspectorName;
            status = Status;
        }


    }
}
