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
            ////instansiate array LONG way
            //int [] myArray = new int[5];

            //myArray[0] = 7;
            //myArray[1] = 13;
            //myArray[2] = 6;
            //myArray[3] = 5;
            //myArray[4] = 4;
            //myArray[5] = 99;

            //instantiate array short way

            int[] myArray = { 7, 13, 6, 5, 4, 99 };

            Array.Sort(myArray);

            //Console.WriteLine(myArray.ToString());
            ////Console.WriteLine(myFirstArray[9]);
            //Console.ReadLine();
        }
    }
}
