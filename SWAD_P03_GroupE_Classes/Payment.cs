using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes;
public class Payment
{
    public string PaymentID { get; set; } 
    public float Amount { get; set; } 
    public string PaymentMethod { get; set; } 
    public string PaymentStatus { get; set; } 
    public DiscountCode DiscountCode { get; set; } 

    public Payment()
    {
    }

    public Payment(float amount, string paymentMethod, string paymentStatus)
    {
        PaymentID = Guid.NewGuid().ToString();
        Amount = amount;
        PaymentMethod = paymentMethod;
        PaymentStatus = paymentStatus;
        DiscountCode = null; 
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

