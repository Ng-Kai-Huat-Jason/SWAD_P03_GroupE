using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class Insurance
    {
        public string InsuranceID { get; set; }
        public string CoverageDetails { get; set; }
        public DateTime InsuranceStartDate { get; set; }
        public DateTime InsuranceEndDate { get; set; }

        // Constructor for Insurance class
        public Insurance(string insuranceID, string coverageDetails, DateTime insuranceStartDate, DateTime insuranceEndDate)
        {
            if (string.IsNullOrWhiteSpace(insuranceID))
            {
                throw new ArgumentException("Insurance ID cannot be empty.", nameof(insuranceID));
            }

            if (insuranceEndDate <= insuranceStartDate)
            {
                throw new ArgumentException("Insurance end date must be after the start date.", nameof(insuranceEndDate));
            }

            InsuranceID = insuranceID;
            CoverageDetails = coverageDetails;
            InsuranceStartDate = insuranceStartDate;
            InsuranceEndDate = insuranceEndDate;
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public static Insurance CreateInsurance()
        {
            string input;

            // Insurance ID
            string insuranceID = Guid.NewGuid().ToString();

            // Coverage Details
            Console.Write("Enter Coverage Details: ");
            string coverageDetails = Console.ReadLine();

            // Insurance Start Date
            DateTime insuranceStartDate;
            while (true)
            {
                Console.Write("Enter Insurance Start Date (YYYY-MM-DD): ");
                input = Console.ReadLine();
                if (DateTime.TryParse(input, out insuranceStartDate))
                {
                    break;
                }
                Console.WriteLine("Invalid date format. Please enter in YYYY-MM-DD format.");
            }

            // Insurance End Date
            DateTime insuranceEndDate;
            while (true)
            {
                Console.Write("Enter Insurance End Date (YYYY-MM-DD): ");
                input = Console.ReadLine();
                if (DateTime.TryParse(input, out insuranceEndDate))
                {
                    break;
                }
                Console.WriteLine("Invalid date format. Please enter in YYYY-MM-DD format.");
            }

            try
            {
                return new Insurance(insuranceID, coverageDetails, insuranceStartDate, insuranceEndDate);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public bool ValidateInsurance()
        {
            // Validate InsuranceID is not empty
            if (string.IsNullOrWhiteSpace(InsuranceID))
            {
                Console.WriteLine("Insurance ID cannot be empty.");
                return false;
            }

            // Validate that the end date is after the start date
            if (InsuranceEndDate <= InsuranceStartDate)
            {
                Console.WriteLine("Insurance end date must be after the start date.");
                return false;
            }

            // Additional validations can be added here

            return true;
        }


        // Implemented by Yeo Jin Rong, S10258457, Use Case : Register Vehicle as Car Owner
        public void DisplayInsuranceInformation()
        {
            Console.WriteLine("Insurance Information:");
            Console.WriteLine($"Insurance ID: {InsuranceID}");
            Console.WriteLine($"Coverage Details: {CoverageDetails}");
            Console.WriteLine($"Start Date: {InsuranceStartDate.ToShortDateString()}");
            Console.WriteLine($"End Date: {InsuranceEndDate.ToShortDateString()}");
        }
    }
}
