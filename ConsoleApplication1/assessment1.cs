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
            //with input
            string stFirstName = "Oluwasayo";
            string stLastName = "Babalola";
            DateTime dob = new DateTime(1994, 10, 31);
            string address1 = "189 Campbell";
            string address2 = "20 Emily Akintola";
            string city = "Marina";
            string state = "Lagos";
            string zip = "34287";
            string country = "Nigeria";

            string student = ("Hello there," + Environment.NewLine + "I am " + stFirstName + " " + stLastName + Environment.NewLine + "Born on " + dob + "." + Environment.NewLine + "I live in " + address1 + " " + "or " + address2 + " " + "in" + " " + city + "," + " " + state + "," + " " + zip + "," + " " + country);

            Console.WriteLine(student);


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

        }
    }



}

    


