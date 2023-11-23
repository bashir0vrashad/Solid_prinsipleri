using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Open
{
    public class CreditCardPaymentProcessor : PaymentProcessor
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Debet Karti ile {amount} manat odenis edildi.");
          
        }
    }
}
