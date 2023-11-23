using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Dependency__prinsip
{
    public class SMSService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS gönderildi: {message}");
          
        }
    }
}
