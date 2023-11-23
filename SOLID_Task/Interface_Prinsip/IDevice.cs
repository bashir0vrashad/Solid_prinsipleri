using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Interface_Prinsip

{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        bool IsOn();
    }
}
