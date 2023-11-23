using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Single
{

    public class FileWriter
    {
       
        public void WriteFile(string filePath, string content)
        {
           
            File.WriteAllText(filePath, content);
            Console.WriteLine("File yazıldı.");
        }
    }
}
