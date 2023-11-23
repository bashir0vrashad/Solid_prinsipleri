using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Liskov
{
   
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Miyav!");
        }
    }
}
