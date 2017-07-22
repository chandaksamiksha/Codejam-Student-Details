using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Tavisca.Training2017.CodeJam.StudentDetails
{
    class Input
    { Validation validation = new Validation();
        Logging logging = new Logging();
        Details details;
        public Input()
        {
            details = new Details();
        }
        public void SetInput(string fileName)
        {
           
            Console.WriteLine("Enter The Details :");
            string firstName = " ";
            string lastName = " ";
            string mobileNumber = " ";
            string mailId = " ";
            string address = " ";
            string coursePursuing = " ";
            string mentorName = " ";
            string emergencyContactNumber = " ";
            do
            {
                Console.WriteLine(" First Name : ");

                firstName = Console.ReadLine();
                if (Regex.Match(firstName, @"[a-zA-Z]").Success)
                    details.FirstName = firstName;
                else
                    logging.Logger("User Entered incorrect Name");
                firstName = " ";
            } while (firstName == " ");

            do
            {
                Console.Write("Enter Last Name :");
                lastName = Console.ReadLine();
                if (validation.checkString(lastName))
                    details.LastName = lastName;
                else
                    logging.Logger("User Entered incorrect Surname");
            } while (lastName == " ");

            do
            {
                Console.Write("Mobile Number :");
                mobileNumber = Console.ReadLine();
                if (validation.CheckMobileNumber(mobileNumber))
                    details.MobileNumber = mobileNumber;
                else logging.Logger("User Entered incorrect MobileNumber");
            } while (mobileNumber == " ");

            do
            {
                Console.Write("Mail Id :");
                mailId = Console.ReadLine();
                if (validation.CheckEmail(mailId))
                    details.MailId = mailId;
                else logging.Logger("User Entered incorrect Mail-Id");
            } while (mailId == " ");

            do
            {
                Console.Write("Address :");
                address = Console.ReadLine();
                if (validation.CheckAddress(address))
                    details.Address = address;
                else
                    logging.Logger("User Entered incorrect Address");
            } while (address==" ");
            
            Console.Write("Dob :");
            details.Dob = Convert.ToDateTime(Console.ReadLine());

            do
            {
                Console.Write("Current Course Pursuing :");
                coursePursuing = Console.ReadLine();
                if (validation.checkString(coursePursuing))
                    details.CoursePursuing = coursePursuing;
                else
                    logging.Logger("User Entered incorrect course");
            } while (coursePursuing == " ");

            do
            {
                Console.Write("Mentor Name :");
                mentorName = Console.ReadLine();
                if (validation.checkString(mentorName))
                    details.MentorName = mentorName;
                else
                    logging.Logger("User Entered incorrect Mentor Name");
            } while (mentorName == " ");

            do
            {
                Console.Write("Emergency Contact Number :");
                emergencyContactNumber = Console.ReadLine();
                if (validation.CheckMobileNumber(emergencyContactNumber))
                    details.EmergencyMobileNumber = emergencyContactNumber;
                else
                    logging.Logger("User Entered incorrect Emergency Mobile Number");
            } while (emergencyContactNumber ==" ");

        }
    }
}
