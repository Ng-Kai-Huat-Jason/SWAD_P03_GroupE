using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes;
public class Payment
{
    public string PaymentID { get; set; } // PaymentID is read-only outside of the class
    public float Amount { get; set; } // Amount is read-only outside of the class
    public string PaymentMethod { get; set; } // e.g., "CreditCard", "PayNow"
    public string PaymentStatus { get; set; } // e.g., "Pending", "Confirmed"

    public Payment()
    {
    }

    public Payment(float amount, string paymentMethod, string paymentStatus)
    {
        PaymentID = Guid.NewGuid().ToString();
        Amount = amount;
        PaymentMethod = paymentMethod;
        PaymentStatus = paymentStatus;
    }

    // Implemented by Ng Jing Zhan Garrett, S10257347, Use Case : Make Payment
    public static Payment InitializePayment(float amount, string paymentMethod)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be greater than zero.");
        }
        if (string.IsNullOrEmpty(paymentMethod))
        {
            throw new ArgumentException("Payment method must be provided.");
        }

        return new Payment(amount, paymentMethod, "Pending");
    }


    // Implemented by Ng Jing Zhan Garrett, S10257347, Use Case : Make Payment
    // Method to update the payment status
    public void UpdatePaymentStatus(string newStatus)
    {
        PaymentStatus = newStatus; // Update payment status
    }

    // Implemented by Ng Jing Zhan Garrett, S10257347, Use Case : Make Payment
    // Method to update the payment method (optional)
    public void UpdatePaymentMethod(string newMethod)
    {
        PaymentMethod = newMethod; // Update payment method
    }
}

