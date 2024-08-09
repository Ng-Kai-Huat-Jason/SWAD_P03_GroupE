using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class DriverLicence
    {
        public string LicenceID { get; set; }
        public string LicenceNo { get; set; }
        public int NumberOfDemeritPoints { get; set; }
        public string ClassOfLicence { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Boolean CertificateOfMeritEligilibility { get; set; }

        public DriverLicence()
        {
        }

        public DriverLicence(string licenceID, string licenceNo, int numberOfDemeritPoints, string classOfLicence, DateTime dateOfIssue, bool certificateOfMeritEligibility)
        {
            LicenceID = licenceID;
            LicenceNo = licenceNo;
            NumberOfDemeritPoints = numberOfDemeritPoints;
            ClassOfLicence = classOfLicence;
            DateOfIssue = dateOfIssue;
            CertificateOfMeritEligilibility = certificateOfMeritEligibility;
        }

        // Implemented by Ng Kai Huat Jason, S10262552, Use Case : Register as Renter
        public DriverLicence createLicence(List<Renter> renters)
        {
            static string ReadNonEmptyString(string prompt)
            {
                string input;
                do
                {
                    Console.Write(prompt + ": ");
                    input = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(input));
                return input;
            }

            static DateTime ReadValidDate(string prompt)
            {
                DateTime date;
                do
                {
                    Console.Write(prompt + ": ");
                } while (!DateTime.TryParse(Console.ReadLine(), out date));
                return date;
            }

            static bool ReadYesOrNo(string prompt)
            {
                string input;
                do
                {
                    Console.Write(prompt + ": ");
                    input = Console.ReadLine().ToUpper();
                } while (input != "Y" && input != "N");
                return input == "Y";
            }

            string licenceID = Guid.NewGuid().ToString();
            string licenceNo;
            bool isValidLicenceNo;

            do
            {
                licenceNo = ReadNonEmptyString("Licence Number");
                // Sequence Diagram 9.1, 9.1.1, 9.1.2
                isValidLicenceNo = ValidateLicence(licenceNo, renters);

                if (!isValidLicenceNo)
                {
                    Console.WriteLine("Duplicate Licence Found, Please re-enter your details.");
                }
            } while (!isValidLicenceNo);

            int numberOfDemeritPoints;
            do
            {
                string demeritPointsInput = ReadNonEmptyString("Number of Demerit Points");
                isValidLicenceNo = int.TryParse(demeritPointsInput, out numberOfDemeritPoints);
                if (!isValidLicenceNo)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (!isValidLicenceNo);

            string classOfLicence = ReadNonEmptyString("Class of Licence");
            DateTime dateOfIssue = ReadValidDate("Date of Licence Issue (MM/DD/YYYY)");
            bool certificateOfMeritEligibility = ReadYesOrNo("Eligible for Certificate of Merit? (Y/N)");

            return new DriverLicence(licenceID, licenceNo, numberOfDemeritPoints, classOfLicence, dateOfIssue, certificateOfMeritEligibility);
        }

        // Implemented by Ng Kai Huat Jason, S10262552, Use Case : Register as Renter
        static bool ValidateLicence(string licenceNo, List<Renter> renters)
        {
            foreach (var renter in renters)
            {
                if (renter.DriverLicence != null && renter.DriverLicence.LicenceNo == licenceNo)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
