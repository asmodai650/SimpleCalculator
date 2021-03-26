using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class UnitTest1
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputToDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);

            Assert.AreEqual(5, convertedNumber);
        }
    }
}
