using NUnit.Framework;
using TemperatureLibrary;

namespace TestTemperature
{
    public class Tests
    {
        Converter Converter = new Converter();

        [Test]
        public void Test1()
        {
            double value1 = 2;
            string value2 = "celsius";
            double expected = 35.6;
            double result = Converter.ToF(value1,value2);
            Assert.AreEqual(expected, result);
        }
    }
}