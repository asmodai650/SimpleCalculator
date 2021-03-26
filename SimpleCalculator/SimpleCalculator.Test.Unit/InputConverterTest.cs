using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputToDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);

            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        //Test is looking for an exception
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputToDouble()
        {
            string inputNumber = "#";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
        }
    }
}
