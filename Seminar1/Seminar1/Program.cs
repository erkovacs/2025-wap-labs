using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Program
    {
        private static void SystemDataTypes()
        {
            Console.Write("First Name: ");

            //declare the variable
            //string firstName;
            //store the input from the keyboard
            //firstName = Console.ReadLine();

            //written more concisely
            string firstName = Console.ReadLine();

            Console.WriteLine("");

            DateTime currentTime = DateTime.Now;

            //{0} and {1} are replaced with the arguments
            //Console.WriteLine(string.Format("Hello {0}! Today is {1}.", firstName, DateTime.Now));
            //written more concisely
            Console.WriteLine("Hello {0}! Today is {1}.", firstName, currentTime);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            SystemDataTypes();

            if ("test" == "test")
            {
                Console.WriteLine("True!");
            }
            if ("test".Equals("test"))
            {
                Console.WriteLine("True!");
            }
            var doubleArray = new[] { 1.5, 5.6, 21.1 };
            foreach (var doubleValue in doubleArray)
            {
                Console.WriteLine(doubleValue);
            }
        }
    }
}
