using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    class Outputcs
    {
        internal void GetOutput(string fileName)
        {
            using (StreamReader sr = File.OpenText(fileName))
            {
                string display = "";
                while ((display = sr.ReadLine()) != null)
                {
                    Console.WriteLine(display);
                }
            }
        }
    }
}
