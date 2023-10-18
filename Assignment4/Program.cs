using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringOperationLibrary;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringOperation stringOperation = new StringOperation();

            
            stringOperation.OnStringOperation += StringOperationHandler;

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            stringOperation.MakeFirstCharacterUppercase(input);
        }

        
        static void StringOperationHandler(string input, string result)
        {
            Console.WriteLine($"Original string: {input}");
            Console.WriteLine($"Resulting string: {result}");

            Console.ReadLine();
        }

        
    }
}