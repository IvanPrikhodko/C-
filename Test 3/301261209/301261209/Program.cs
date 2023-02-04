using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ivan Prikhodko 301261209

namespace _301261209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Show the menu until the user presses 0
            while (true)
            {
                // Display the menu with the choices
                string choice = IvanMenu();

                // Handle the choices
                switch (choice)
                {
                    case "1":
                        DemoQuestion3();
                        break;
                    case "2":
                        DemoQuestion4();
                        break;
                    case "3":
                        DemoQuestion5();
                        break;
                    case "0":
                        // Exit if user enters 0
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

        }

 //IVAN MENU QUESTION 1
        static string IvanMenu()
        {
            // Menu display
            Console.WriteLine("+---------------COMP100--TEST-3---------------+");
            Console.WriteLine("|           1) Working with Newton's Law      |");
            Console.WriteLine("|           2) Height Converter               |");
            Console.WriteLine("|           3) Sine and Cosine Table          |");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|           0) To exit the program            |");
            Console.WriteLine("+---------------------------------------------+");

            // Input choices
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            // Return choices
            return input;
        }

//QUESTION 3.2

        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");

            // Call the method
            double force = CalculateGravitationalAttraction(5.972E24, 7.348E22, 384_400_000);

            // Display calculation result
            Console.WriteLine($"The force of attraction is {force:E2}");

            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }

//QUESTION 3.1
        static double CalculateGravitationalAttraction(double mass1, double mass2, double distance)
        {
            
            const double G = 6.674e-11;

            // Calculate the force of attraction
            double force = G * (mass1 * mass2) / Math.Pow(distance, 2);

            // Return the result
            return force;
        }



 //QUESTION 4.2

        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");

            // Call the method three times
            HeightConversion(65);
            HeightConversion(200);
            HeightConversion(490);

            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }

//QUESTION 4.1
        static void HeightConversion(int heightInCm)
        {
            // Convert the height to meters
            double heightInMeters = heightInCm / 100.0;

            // Display result
            Console.WriteLine($"{heightInCm} cm is equivalent to {heightInMeters:F2} meters");
        }



//QUESTION 5.2

        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");

            // Print the table headers
            Console.WriteLine("Angle\t\tSine\t\tCosine");
            Console.WriteLine("--------------------------------------");

            // Loop from 0.600 to 0.609
            for (double angle = 0.600; angle < 0.610; angle += 0.001)
            {
                // Calculate SIN and COS of the angle
                double sine, cosine;
                SineCosine(angle, out sine, out cosine);

                // Print the results
                Console.WriteLine($"{angle:F3}\t\t{sine:F3}\t\t{cosine:F3}");
            }

            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }

//QUESTION 5.1
        static void SineCosine(double angle, out double sine, out double cosine)
        {
            // Calculate SIN and COS of the angle
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
        }

    }
}

//END