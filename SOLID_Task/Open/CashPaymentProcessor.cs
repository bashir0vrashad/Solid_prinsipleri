using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Open
{
    public class CashPaymentProcessor : PaymentProcessor
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Nagd ile {amount} manat odenis edildi.");
          
        }
    }
}
