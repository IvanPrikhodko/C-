using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ivan Prikhodko 301261209
public class Lab5
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Print the menu
            Menu();

            // Wait for the user to choose an option
            Console.WriteLine("Please enter your choice: ");
            string choice = Console.ReadLine();

            // Handle the user's options
            switch (choice)
            {
                case "A":
                    // Convert Pounds to Kilograms
                    OptionA();
                    break;
                case "B":
                    // – Convert Miles to Kilometers
                    OptionB();
                    break;
                case "X":
                    // – Exit the application
                    return;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }

    static void Menu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("A - Convert Pounds to Kilograms");
        Console.WriteLine("B - Convert Miles to Kilometers");
        Console.WriteLine("X - Exit the application");
    }

    static void OptionA()
    {
        // Print a table header
        Console.WriteLine("Pounds\tKilograms");

        // Loop from 200 to 50 in decrements of 5
        for (int pounds = 200; pounds >= 50; pounds -= 5)
        {
            // Convert the pounds to kilograms and print the result
            double kilograms = PoundsToKilograms(pounds);
            Console.WriteLine($"{pounds}\t{kilograms:F2}");
        }
    }

    static double PoundsToKilograms(double pounds)
    {
        // 1 pound is 0.45 kilograms
        return pounds * 0.45;
    }

    static void OptionB()
    {
        // Print a table header
        Console.WriteLine("Miles\tKilometers");

        // Loop from 10 to 100 in increments of 10
        for (int miles = 10; miles <= 100; miles += 10)
        {
            // Convert the miles to kilometers and print the result
            double kilometers;
            MilesToKilometers(miles, out kilometers);
            Console.WriteLine($"{miles}\t{kilometers:F2}");
        }
    }

    static void MilesToKilometers(double miles, out double kilometers)
    {
        // 1 mile is 1.61 kilometers
        kilometers = miles * 1.61;
    }
}