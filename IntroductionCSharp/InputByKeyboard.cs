using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp
{
    public static class ShowFullName
    {
        static void Main()
        {
            string firstName;
            string lastName;
            System.Console.WriteLine("Give your FullName!");
            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();// asking value from keyboard
            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();
            System.Console.WriteLine(
           $"Your Given name is { firstName } { lastName }."); // Displaying user entered input on to console output using string interpolation
        }
    }
}
