using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes;
public class Payment
{
    private static int _lastPaymentID = 0; // Static variable to track the last assigned PaymentID

    public int PaymentID { get; set; } // PaymentID is read-only outside of the class
    public float Amount { get; set; } // Amount is read-only outside of the class
    public string PaymentMethod { get; set; } // e.g., "CreditCard", "PayNow"
    public string PaymentStatus { get; set; } // e.g., "Pending", "Confirmed"

    public Payment()
    {
    }

    public Payment(int paymentID, float amount, string paymentMethod, string paymentStatus)
    {
        PaymentID = paymentID;
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

        Payment payment = new Payment
        {
            PaymentID = GeneratePaymentID(),
            Amount = amount,
            PaymentMethod = paymentMethod,
            PaymentStatus = "Pending"
        };

        return payment;
    }

    // Implemented by Ng Jing Zhan Garrett, S10257347, Use Case : Make Payment
    // Method to generate a unique PaymentID
    private static int GeneratePaymentID()
    {
        _lastPaymentID++; // Increment the last assigned ID
        return _lastPaymentID; // Return the new ID
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

