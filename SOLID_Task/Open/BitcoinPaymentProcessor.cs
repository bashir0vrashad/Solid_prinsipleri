using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Open
{
    public class BitcoinPaymentProcessor : PaymentProcessor
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Bitcoin ile {amount} manat odenis edildi.");
          
        }
    }
}
