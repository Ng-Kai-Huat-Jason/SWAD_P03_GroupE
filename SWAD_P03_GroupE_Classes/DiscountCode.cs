using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes;
public class DiscountCode
{
    public string DiscountID { get; set; }
    public string DiscCode { get; set; } // Renamed to avoid confusion with class name
    public string DiscountType { get; set; }
    public float DiscountValue { get; set; } // Can be percentage or flat value based on DiscountType

    public DiscountCode()
    {
    }

    public DiscountCode(string discountID, string disccode, string discountType, float discountValue)
    public DiscountCode(string disccode, string discountType, float discountValue)
    {
        DiscountID = Guid.NewGuid().ToString();
        DiscCode = disccode;
        DiscountType = discountType;
        DiscountValue = discountValue;
    }

    // Implemented by Ng Jing Zhan Garrett, S10257347, Use Case : Make Payment
    public float ApplyDiscount(float amount)
    {
        if (DiscountType == "Percentage")
        {
            return amount - (amount * (DiscountValue / 100));
        }
        else if (DiscountType == "Flat")
        {
            return amount - DiscountValue;
        }
        else
        {
            throw new InvalidOperationException("Unknown discount type");
        }
    }
}