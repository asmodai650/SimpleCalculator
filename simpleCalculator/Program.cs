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
            //string userName = Console.ReadLine().ToLower();
            //string password = Console.ReadLine().ToLower();


            //if (userName.Equals("danny") && password.Equals("741852"))
            //{
            //    Console.WriteLine("Hello, Danny");
            //}

            //else if (userName.Equals("danny") && !password.Equals("741852"))
            //{
            //    Console.WriteLine("Wrong password, idiot!");
            //}

            //else
            //{
            //    Console.WriteLine("STRANGER DANGER!!!!");
            //}

            //switch (userName)
            //{
            //    case "danny":
            //        Console.WriteLine("Hello, Danny");
            //        break;
            //
            //    default:
            //        Console.WriteLine("Hello, stranger!");
            //        break;
            //}

            //Person person1 = new Person();
            //Console.WriteLine(person1.getAge());
            //person1.setAge(29);
            //Console.WriteLine(person1.getAge());

            //Person.greet();

            try
            {
                string input = Console.ReadLine();

                int convertedNumber;
                bool isconvertedNumberSuccessfully = int.TryParse(input, out convertedNumber);

                if (!isconvertedNumberSuccessfully)
                {
                    throw new Exception("Conversion not working");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}
