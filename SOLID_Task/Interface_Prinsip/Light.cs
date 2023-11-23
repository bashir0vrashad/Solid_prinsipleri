using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Interface_Prinsip
{
    public class Light : IDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Light On.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Light Off.");
        }

        public bool IsOn()
        {
            return isOn;
        }
    }
}
