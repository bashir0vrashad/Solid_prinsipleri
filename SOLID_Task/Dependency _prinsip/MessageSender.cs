using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Dependency__prinsip
{
    public class MessageSender
    {
        private readonly IMessageService messageService;

        public MessageSender(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Mesaj gonderilir...");
            messageService.Send(message);
        }
    }
}
