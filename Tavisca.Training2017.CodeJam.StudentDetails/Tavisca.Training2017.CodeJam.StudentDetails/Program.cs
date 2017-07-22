using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string path = @"D:\Student Details\";
            string fileName;
            
           

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            CreateDirectory createDirectory = new CreateDirectory();
            Input input = new Input();
            Outputcs output = new Outputcs();
            createDirectory.GenerateDirectroy(directoryInfo);
            CreateFile createFile = new CreateFile();
            fileName=createFile.GenerateFile();
           
            input.SetInput(fileName);
            output.GetOutput(fileName);
          
            Console.ReadKey();
        }

      
       


    }
}
