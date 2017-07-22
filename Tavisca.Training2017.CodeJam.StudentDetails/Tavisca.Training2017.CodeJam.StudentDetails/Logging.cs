using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    class Logging
    {
        string logFile = @"D:\Student Details\LogFile.txt";
        internal void Logger(string v)
        {
            using (StreamWriter streamWriter = File.AppendText(logFile))
            {
                streamWriter.WriteLine(v);
            }
        }
        
    }
}
