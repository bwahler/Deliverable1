using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receive input from user
            double value1;
            double value2;
            double value3;
            Console.WriteLine("Please enter a dollar amount");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a dollar amount");
            value2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a dollar amount");
            value3 = Convert.ToDouble(Console.ReadLine());

            //Processing Calculations
            double valueTotal, valueAverage, valueSmall, valueLarge;
            valueTotal = value1 + value2 + value3;
            valueAverage = valueTotal / 3;
            double[] Values = new[] { value1, value2, value3 };
            valueSmall = Values.Min();
            valueLarge = Values.Max();

            // Output of total, average, smallest and largest amounts
            Console.WriteLine("Total Amount: " + valueTotal);
            Console.WriteLine("Average: " + valueAverage);
            Console.WriteLine("Smallest Amount: " + valueSmall);
            Console.WriteLine("Largest Amount: " + valueLarge);

            // Output of different currencies
            Console.WriteLine("Total value in US Dollar: " + valueTotal.ToString("c", CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine("Total value in Japense Yen: " + valueTotal.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Total value in Swedish Krona: " + valueTotal.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine("Total value in Thai Baht: " + valueTotal.ToString("c", CultureInfo.CreateSpecificCulture("th-TH")));
        }
    }
}
