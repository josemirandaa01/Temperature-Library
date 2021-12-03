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

        public double ToC(double x, string y)
        {
            if (y == ("kelvin"))
            {
                kelvin = x - 273.15; ;
                return kelvin;
            }
            else if (y == "celsius")
            {
                celsius = x;
                return celsius;
            }
            else if (y == "fahrenheit")
            {
                celsius = (x - 32) * 5 / 9; ;
                return celsius;
            }

            return 0;

        }

        public double ToK(double x, string y)
        {
            if (y == ("kelvin"))
            {
                kelvin = x;
                return kelvin;
            }
            else if (y == "celsius")
            {
                kelvin = x + 273.15;
                return kelvin;
            }
            else if (y == "fahrenheit")
            {
                kelvin = (x - 32) * 5 / 9 + 273.15;
                return kelvin;
            }

            return 0;

        }

    }
}
