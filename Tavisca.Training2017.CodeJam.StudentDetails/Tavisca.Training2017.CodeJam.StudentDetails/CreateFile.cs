using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    class CreateFile
    {
        string path = @"D:\Student Detail\";
        string logFile = @"D:\Student Details\LogFile.txt";
        string fileName;
        Guid guid;
        Logging logging = new Logging();
        internal string GenerateFile()
        {
            guid = Guid.NewGuid();
            fileName = path + guid + ".txt";
            FileInfo fileInfo = new FileInfo(fileName);
            FileInfo logFileInfo = new FileInfo(logFile);
            try
            {
                if (logFileInfo.Exists) { }
                else { using (logFileInfo.Create()) { } }
                if (fileInfo.Exists)
                        {
                    logging.Logger("File already exist");
                }
                else
                        {
                            using (fileInfo.Create())
                            {
                        logging.Logger("File Created");
                    }
                        }
            }
            catch (IOException)
            {
                logging.Logger("File Could not be created");
                
            }
            return fileName;

        }
    }
}
