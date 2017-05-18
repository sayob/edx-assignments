using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //with input
        static void Main(string[] args)
        {
            #region Data Types
            ////with input
            //string stFirstName = "Oluwasayo";
            //string stLastName = "Babalola";
            //DateTime dob = new DateTime(1994, 10, 31);
            //string address1 = "189 Campbell";
            //string address2 = "20 Emily Akintola";
            //string city = "Marina";
            //string state = "Lagos";
            //string zip = "34287";
            //string country = "Nigeria";

            //string student = ("Hello there," + Environment.NewLine + "I am " + stFirstName + " " + stLastName + Environment.NewLine + "Born on " + dob + "." + Environment.NewLine + "I live in " + address1 + " " + "or " + address2 + " " + "in" + " " + city + "," + " " + state + "," + " " + zip + "," + " " + country);

            //Console.WriteLine(student);


            ///////-------prompts for input (comment out the code above (with input) before uncommenting the code below and then run)--------//////
            ////Console.WriteLine("Enter Firstname");
            ////string firstName = Console.ReadLine();
            ////Console.WriteLine("Enter Lastname");
            ////string lastName = Console.ReadLine();
            ////Console.WriteLine("Enter Date of Birth (separate with comma)");
            ////string dob = Console.ReadLine();
            ////Console.WriteLine("Enter Address 1");
            ////string address1 = Console.ReadLine();
            ////Console.WriteLine("Enter Address 2");
            ////string address2 = Console.ReadLine();
            ////Console.WriteLine("Enter City");
            ////string city = Console.ReadLine();
            ////Console.WriteLine("Enter State");
            ////string state = Console.ReadLine();
            ////Console.WriteLine("Enter Zip");
            ////string zip = Console.ReadLine();
            ////Console.WriteLine("Enter Country");
            ////string country = Console.ReadLine();

            ////Console.WriteLine("Hello there," + Environment.NewLine + "I am " + firstName + " " + lastName + Environment.NewLine + "Born on " + dob + "." + Environment.NewLine + "I live in " + address1 + " " + "or " + address2 + " " + "in" + " " + city + "," + " " + state + "," + " " + zip + "," + " " + country);
            #endregion

            #region Condition Statements
            ////condition statements
            //bool result = true;
            //if (result)
            //    Console.WriteLine("blah");
            //Console.WriteLine("blah blah");
            //Console.WriteLine("blah blah blah");
            


            ////assignment ---loop conditions
            ////int x; //represents X
            ////int o; //represents O
            ////for (x = 0; x < 8; x++) 
            ////{
            ////    for (o = 0; o < 8; o++)
            ////    {
            ////        while ((o + x) % 2 == 0)
            ////        {
            ////            Console.Write("X");
            ////        }
            ////        while ((o + x) % 2 == 1)
            ////        {
            ////            Console.Write("O");
            ////        }

            ////    } i = 0, Console.WriteLine("Start: {0}",i); i < j; i++, j--, Console.WriteLine("i={0}, j={1}", i, j)
            ////    Console.WriteLine();
            ////}

            

            ////for (int row = 1; row < 9; row++)
            ////{ 

            ////    for (int col = 1; col < 9; col++)
            ////    {
            ////        if ((row + col) % 2 == 0)
            ////            Console.Write("X");
            ////        else if ((row + col) % 2 == 1)
            ////        {
            ////            Console.Write("O");
            ////        }
            ////        else
            ////        {

            ////        }
            ////    }
            ////    Console.WriteLine();
            ////}

            //for (var i = 0; i < 8; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("XOXOXOXO");
            //    }
            //    else
            //    {
            //        Console.WriteLine("OXOXOXOX");
            //    }
            //}


            ////calls a the sum method 
            //int first = 5;
            //int second = 10;

            //int rezult = Sum(first, second);
            //Console.WriteLine("Sum of {0} and {1} is: {2}", first, second, rezult);
            #endregion

            #region Methods
            string firsts;
            string last;
            string birthday;
            string address;
            string citys;
            string states;
            string zipcode;
            string countrys;
            //calling student, teacher method below //call each of the methods to prompt for input from a user of your application
            GetStudentInformation();
            GetTeacherInformation();
            //string studentDetails = PrintStudentDetails(firsts, last, birthday, string address, string city, string state, string zip, string country);
            PrintStudentDetails(firsts, last, birthday, string address, string city, string state, string zip, string country)
            Console.WriteLine("{0} {1} was born on: {2}", firsts, last, birthday + " " + "Lives in: {3} {4} {5} {6} {7} ", address, city, state, zip, country);

            #endregion

        }

        //calling a method from another method example --this method is called above
        public static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }




        #region Module Three Assignment
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth date: ");
            string dob = Console.ReadLine();
            Console.WriteLine("Enter the student's address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the student's city:");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the student's state: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the student's zip code: ");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter the student's country: ");
            string country = Console.ReadLine();
            // Code to finish getting the rest of the student data DateTime dob = new DateTime(1994, 10, 31);
            Console.WriteLine
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's course: ");
            string course = Console.ReadLine();
            Console.WriteLine("Enter the teacher's uprogram: ");
            string uprogram = Console.ReadLine();
            Console.WriteLine("Enter the teacher's degree: ");
            string degree = Console.ReadLine();

        }


        static void PrintStudentDetails(ref string firsts, ref string last, ref string birthday, ref string address, ref string city, ref string state, ref string zip, ref string country)
        {
           // Console.WriteLine("{0} {1} was born on: {2}", firsts, last, birthday + " " + "Lives in: {3} {4} {5} {6} {7} ", address, city, state, zip, country);
            return;
        }





        #endregion

    }



}

    


