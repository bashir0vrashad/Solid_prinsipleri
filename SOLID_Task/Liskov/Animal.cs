using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Liskov
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Ses Ses Ses Ses");
        }
    }

    
}
