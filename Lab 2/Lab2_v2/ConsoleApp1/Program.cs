using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Ivan Prikhodko 301261209


namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // INPUT

            int assetValue = 28000;
            int annualDepreciation = 4000;
            int depreciation = 0;
            int counter = 0;

            // OUTPUT
            Console.WriteLine("                             END-OF-YEAR    ACCUMULATED \n" +
                "YEAR        DEPRECIATION        VALUE      DEPRECIATION\n" +
                "----       ------------     -----------    -------------");

            // PROCESSING

            do
            {
                counter++;

                assetValue = assetValue - annualDepreciation;

                depreciation = depreciation + annualDepreciation;

             // OUTPUT

                Console.WriteLine($" {counter}" + "\t" + "\t" +
                                  $"{annualDepreciation}" + "\t" + "\t" +
                                  $"{assetValue}" + "\t" + "\t" +
                                  $"{depreciation}");

            } while (counter < 7);

        }
    }
}
