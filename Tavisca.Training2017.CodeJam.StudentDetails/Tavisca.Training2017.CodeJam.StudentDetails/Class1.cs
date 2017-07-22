using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    public class Class1
    {
        static Details student = new Details();
        string store = JsonConvert.SerializeObject(student);
    }
}
