using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Open
{
    public abstract class PaymentProcessor
    {
        public abstract void ProcessPayment(double amount);
    }
}
