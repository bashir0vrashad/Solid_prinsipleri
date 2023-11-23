using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Task.Single
{
    public class FileReader
    {
      
        public string ReadFile(string filePath)
        {
          
            var content = File.ReadAllText(filePath);
            Console.WriteLine("File oxundu.");
            return content;
        }
    }


}
