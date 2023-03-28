using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachExercise2
{
    internal class Program
    {
        /// <summary>
        /// Enhanced if statements
        /// Date : 27 Mar 2023
        /// </summary>
        /// Foreach Challenge
        /// <param name="Jack"></param>
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType;

            Console.Write("Enter a value : ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered : ");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.Write("Enter : ");
            int inpytType = Convert.ToInt32(Console.ReadLine());

            switch (inpytType)
            {
                case 1:
                    //check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    //check for integer
                    int retValue = 0;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    //check for boolean
                    bool retFlag = false;
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect the input type, somthing is wrong");
                    break;
            }

            Console.WriteLine("You have entered a value : {0}", inputValue);
            if (valid)
            {
                Console.WriteLine("It is valid : {0} ", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid {0}", inputValueType);
            }
            Console.ReadKey();
        }

        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}

