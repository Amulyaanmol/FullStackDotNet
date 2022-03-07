
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp
{
    public static class Variable
    {
        static void Main()
        {
            string change; //create variable of type string
            string message = "Enjoy the day!"; // Assign value to variable
            change = "do you think soo?";
            System.Console.WriteLine(message);
            System.Console.WriteLine(change);
            message = "yes."; // changing the value of variable
            System.Console.WriteLine(message);
        }
    }
}
