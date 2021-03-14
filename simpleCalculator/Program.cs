using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "Here is some text";
            string someOtherText = "Here is some other text";

            bool isEqual = someOtherText.Equals(someText, StringComparison.OrdinalIgnoreCase);

            string addedText = someText + " " + someOtherText + " here is some more text.";
            string formattedText = string.Format("{0} {1} here is some more text.", someText, someOtherText);

            string anotherText = string.Empty; //use instead of string anotherText = "";

            string replacedText = someText.Replace("text", "string");

            Console.WriteLine(addedText);
            Console.WriteLine(formattedText);

            Console.WriteLine(someText);
            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[8]);

            Console.WriteLine(someText.Substring(8, 4));

            Console.WriteLine(someText.ToLower());
            Console.WriteLine(someText.ToUpper());
            Console.WriteLine(someText.Substring(8, 4).ToUpper());

            






            Console.ReadLine();

        }
    }
}
