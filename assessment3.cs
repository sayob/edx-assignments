using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();
            GetDegreeInfo();
            GetProgramInfo();
            GetCourseInfo();
        }

        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday (yyyy/mm/dd): ");
            DateTime birthday = ValidateBirthday(Console.ReadLine());
            Console.WriteLine("Enter the student's country: ");
            string country = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthday, country);
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday, string country)
        {
            Console.WriteLine("The student {0} {1} was born on: {2} and lives in {3}.\n", first, last, birthday, country);
        }

        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday (yyyy/mm/dd): ");
            DateTime birthday = ValidateBirthday(Console.ReadLine());
            Console.WriteLine("Enter the teacher's country: ");
            string country = Console.ReadLine();

            PrintTeacherDetails(firstName, lastName, birthday, country);
        }

        static void PrintTeacherDetails(string first, string last, DateTime birthday, string country)
        {
            Console.WriteLine("The teacher {0} {1} was born on: {2} and lives in {3}.\n", first, last, birthday, country);
        }

        static void GetDegreeInfo()
        {
            Console.WriteLine("Enter the degree: ");
            string degree = Console.ReadLine();
            Console.WriteLine("Enter the school: ");
            string school = Console.ReadLine();
            Console.WriteLine("Enter the number of credits obtained: ");
            int credits = Convert.ToInt32(Console.ReadLine());

            PrintDegreeDetails(degree, school, credits);
        }

        static void PrintDegreeDetails(string degree, string school, int credits)
        {
            Console.WriteLine("She studied {0} at {1}. Credits: {2}.\n", degree, school, credits);
        }

        static void GetProgramInfo()
        {
            Console.WriteLine("Enter the name of the program: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the number of degrees offered in the program: ");
            int degreesOffered = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the department head: ");
            string departmentHead = Console.ReadLine();

            PrintProgramDetails(programName, degreesOffered, departmentHead);
        }

        static void PrintProgramDetails(string progname, int dOffered, string departmentH)
        {
            Console.WriteLine("The {0} offer {1} degrees. Department head: {2}.\n", progname, dOffered, departmentH);
        }

        static void GetCourseInfo()
        {
            Console.WriteLine("Enter the name of the course: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the field of study: ");
            string studyField = Console.ReadLine();
            Console.WriteLine("Enter the course credits: ");
            int courseCredits = Convert.ToInt32(Console.ReadLine());

            PrintCourseDetails(courseName, studyField, courseCredits);
        }

        static void PrintCourseDetails(string name, string field, int credits)
        {
            Console.WriteLine("Course: {0}." + Environment.NewLine + "Field of study: {1}." + Environment.NewLine + "Credits: {2}.\n", name, field, credits);
        }

        static DateTime ValidateBirthday(String date)
        {
            try
            {
                DateTime birthday = DateTime.Parse(date);

                // Check if student's age is greater than 18.
                if (birthday.AddYears(18).CompareTo(DateTime.Today) > 1)
                {
                    Console.WriteLine("The age is okay.");
                }

                return birthday;
            }
            catch (FormatException)
            {
                Console.WriteLine("The age is below 18 years which is expected.");
                return DateTime.Today;
            }
        }
    }
}

