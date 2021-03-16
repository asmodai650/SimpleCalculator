using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    class StringToIntConverter
    {
        public int convert(string input)
        {
            try
            {
                int convertedNumber;
                bool isconvertedNumberSuccessfully = int.TryParse(input, out convertedNumber);

                if (!isconvertedNumberSuccessfully)
                {
                    throw new Exception("Conversion not working");
                }

                return convertedNumber;
            }

            catch (Exception innerEx)
            {
                throw new Exception(innerEx.Message);
            }
        }
    }
}
