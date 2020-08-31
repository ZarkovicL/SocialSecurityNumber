using System;
using System.Globalization;

namespace SocialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Social Security Number (YYMMDD-XXXX");

            string socialSecurityNumber = Console.ReadLine();

            string genderNumberString = socialSecurityNumber.Substring(9, 1);

            int genderNumber = int.Parse(genderNumberString);

            bool isFemale = genderNumber % 2 == 0;

            string Gender = isFemale ? "Female" : "Male";

            string birthDateString = socialSecurityNumber.Substring(0, 6);

            DateTime birthDate = DateTime.ParseExact(birthDateString, "yymmdd", CultureInfo.InvariantCulture);

            int age = DateTime.Today.Year - birthDate.Year;

            if (birthDate.Month > DateTime.Today.Month 
                || birthDate.Month == DateTime.Today.Month && birthDate.Day > DateTime.Now.Day) 
            {
                age--;
            }

            Console.WriteLine($"{Gender}, {age}");

   

        }
    }
}
