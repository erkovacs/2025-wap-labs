using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Program
    {
        
        #region TestRegion

        static void Main(string[] args)
        {
            var adder = new Adder();

            Console.WriteLine("Input operand 1:");
            var operand1 = Console.ReadLine();

            Console.WriteLine("Input operand 2:");
            var operand2 = Console.ReadLine();

            try
            {
                var operand1Double = double.Parse(operand1);
                var operand2Double = double.Parse(operand2);
                
                var sum = adder.Add(operand1Double, operand2Double);

                Console.WriteLine($"Sum is: {operand1} + {operand2} = {sum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(Console.ReadLine());
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var dict = new Dictionary<string, int>();
            dict.Add("One", 1);
            dict.Add("Two", 2);
            foreach (var item in dict.Keys)
            { 
                Console.WriteLine($"Key={item} Value={dict[item]}");
            }
            Console.WriteLine(dict["One"]);
        }
        #endregion TestRegion
    }
}
