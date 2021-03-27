using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myFirstList = new List<int>();

            Console.WriteLine(myFirstList.Count());

            myFirstList.Add(10);
            myFirstList.Add(5);

            Console.WriteLine(myFirstList.Count());
            Console.ReadLine();
        }
    }
}
