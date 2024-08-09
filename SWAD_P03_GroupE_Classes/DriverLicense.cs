using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class DriverLicense
    {
        // This class is not utilised for use case, only kept here for parity with other use cases
        public string LicenseID { get; set; }
        public string LicenseNo { get; set; }
        public int NumberOfDemeritPoints { get; set; }
        public string ClassOfLicense { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Boolean CertificateOfMeritEligilibility { get; set; }

        public DriverLicense()
        {
            
        }
        public DriverLicense(string licenseID, string licenseNo, int numberOfDemeritPoints, string classOfLicense, DateTime dateOfIssue, bool certificateOfMeritEligilibility)
        {
            LicenseID = licenseID;
            LicenseNo = licenseNo;
            NumberOfDemeritPoints = numberOfDemeritPoints;
            ClassOfLicense = classOfLicense;
            DateOfIssue = dateOfIssue;
            CertificateOfMeritEligilibility = certificateOfMeritEligilibility;
        }
    }
}
