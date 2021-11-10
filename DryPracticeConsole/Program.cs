using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DRYpractice;

namespace DryPracticeConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first value then press ENTER");
            string firstnum = Console.ReadLine();
            Console.WriteLine("Please input your second value then press ENTER");
            string secondnum = Console.ReadLine();
            Console.WriteLine("Please enter a + to add, - to subtract, / to divide, or * to multiply. Then press ENTER");
            string funct = Console.ReadLine();

            //now we determine what the user wants to do and display the output

            //create a variable to hold output
            double result = 0;

            //create an object for our library        
            processor test = new processor();

            if (funct.Contains("+"))
            {
                //we add
                result = test.add(Convert.ToInt32(firstnum), Convert.ToInt32(secondnum));
            }
            if (funct.Contains("-"))
            {
                //we subtract
                result = test.subtract(Convert.ToInt32(firstnum), Convert.ToInt32(secondnum));
            }
            if (funct.Contains("*"))
            {
                //we multiply
                result = test.multiply(Convert.ToInt32(firstnum), Convert.ToInt32(secondnum));
            }
            if (funct.Contains("/"))
            {
                //we divide
                result = test.divide(Convert.ToDouble(firstnum), Convert.ToDouble(secondnum));
            }

            Console.WriteLine("Your result is");
            Console.WriteLine(result.ToString());
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
