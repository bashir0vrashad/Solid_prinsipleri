using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Interface_Prinsip

{
    public class Fan : IDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Fan On");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Fan Off");
        }

        public bool IsOn()
        {
            return isOn;
        }
    }
}
