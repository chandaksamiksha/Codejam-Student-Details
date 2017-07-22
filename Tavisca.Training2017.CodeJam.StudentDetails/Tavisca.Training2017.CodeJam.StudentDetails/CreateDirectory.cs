using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    class CreateDirectory
    {
        Logging logging = new Logging();
        
        internal void GenerateDirectroy(DirectoryInfo directoryInfo)
        {
            try
            {
                if (directoryInfo.Exists)
                {
                    logging.Logger("Directory already exist");
                }

                else
                {
                    directoryInfo.Create();
                    logging.Logger("Directory created");
                }

                }
            catch (IOException)
            {
                logging.Logger("Directory Could not be created");
            }
        }
    }
}
