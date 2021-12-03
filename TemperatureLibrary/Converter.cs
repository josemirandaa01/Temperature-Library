using System;

namespace TemperatureLibrary
{
    public class Converter
    {
        double x;
        double celsius = 0;
        double fahrenheit = 0;
        double kelvin = 0;

        public double ToF(double x, string y)
        {
            if (y == ("kelvin"))
            {
                fahrenheit = (x - 273.15) * 9 / 5 + 32;
                return fahrenheit;
            }
            else if (y == "celsius")
            {
                fahrenheit = (x * 1.8) + 32;
                return fahrenheit;
            }
            else if (y == "fahrenheit")
            {
                return fahrenheit;
            }

            return 0;
        }


    }
}
