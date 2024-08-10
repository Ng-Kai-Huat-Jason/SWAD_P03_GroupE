using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class InspectionReport
    {
        public string InspectionID { get; set; }
        public string ReportDetails { get; set; }
        public DateTime InspectionDateTime { get; set; }
        public string InspectorName { get; set; }
        public string Status { get; set; }

        public InspectionReport(){}

        public InspectionReport(string inspectionID, string reportDetails, DateTime inspectionDateTime, string inspectorName, string status)
        {
            InspectionID = inspectionID;
            ReportDetails = reportDetails;
            InspectionDateTime = inspectionDateTime;
            InspectorName = inspectorName;
            Status = status;
        }


    }
}
