using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    public class Details
    {
        public string firstName; 
        public string lastName; 
        public string mobileNumber; 
        public string mailId;
        public string address; 
        public DateTime dob; 
        public string coursePursuing; 
        public string mentorName;
        public string emergencyMobileNumber;

           public string FirstName
           {
               get { return firstName; }
               set { firstName = value; }
           }

           public string LastName
           {
               get { return lastName; }

               set { lastName = value; }
           }
           public string MobileNumber
           {
               get { return mobileNumber; }
               internal set { mobileNumber = value; }
           }
           public string MailId
           {
               get { return mailId; }
               internal set { mailId = value; }
           }
           public string Address
           {
               get { return address; }
               internal set { address = value; }
           }
           public DateTime Dob
           {
               get { return dob; }
               internal set { dob = value; }
           }
           public string CoursePursuing
           {
               get { return coursePursuing; }
               internal set { coursePursuing = value; }
           }
           public string MentorName
           {
               get { return mentorName; }
               internal set { mentorName = value; }
           }
           public string EmergencyMobileNumber
           {
               get { return emergencyMobileNumber; }
               internal set { emergencyMobileNumber = value; }
           }

    }
}   
   