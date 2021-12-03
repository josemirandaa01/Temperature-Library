using NUnit.Framework;
using TemperatureLibrary;

namespace TestTemperature
{
    public class Tests
    {
        Converter Converter = new Converter();

        [Test]
        public void Celsius_2_ToFahrenheit()
        {
            double value1 = 2;
            string value2 = "celsius";
            double expected = 35.6;
            double result = Converter.ToF(value1,value2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Celsius_2_ToKelvin()
        {
            double value1 = 2;
            string value2 = "celsius";
            double expected = 275.15;
            double result = Converter.ToK(value1, value2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Fahrenheit_5_ToCelsius()
        {
            double value1 = 5;
            string value2 = "fahrenheit";
            double expected = -15;
            double result = Converter.ToC(value1, value2);
            Assert.AreEqual(expected, result);
        }
    }
}