using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {

 
        static void Main(string[] args)
        {
            double salesValue = sales();
            double commisionValue = commission(salesValue);
            Console.WriteLine("The commision for " + salesValue + " is " + commisionValue + ".");

        }


        //method 1
        static double sales()
        {
            double sales;
            Console.WriteLine("Enter the sales value for today.");
            sales = Convert.ToDouble(Console.ReadLine());
            return sales;
        }

        //method 2
        static double commission(double sales)
        {
            
            if (sales >= 0 && sales < 1000)
            {
                return (sales * 0.03); 
              
            }
            else if (sales >= 1000 && sales < 3000)
            {
                return (sales * 0.04);
              
            }
            else if (sales >= 3000)
            {
                return (sales * 0.05);
             
            }
            else
            {
                return 0; // ERROR, negative number
            }
            
        }
    }
}
