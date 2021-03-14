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
            string userName = Console.ReadLine().ToLower();
            string password = Console.ReadLine().ToLower();


            if (userName.Equals("danny") && password.Equals("741852"))
            {
                Console.WriteLine("Hello, Danny");
            }

            else if (userName.Equals("danny") && !password.Equals("741852"))
            {
                Console.WriteLine("Wrong password, idiot!");
            }

            else
            {
                Console.WriteLine("STRANGER DANGER!!!!");
            }

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

            Console.ReadLine();

        }
    }
}
