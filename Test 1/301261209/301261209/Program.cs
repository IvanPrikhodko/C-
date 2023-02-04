using System;

//Ivan Prikhodko 301261209

namespace comp100_test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 1:");
            Console.WriteLine("-----------");
            Exercise1();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 2:");
            Console.WriteLine("-----------");
            Exercise2();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 3:");
            Console.WriteLine("-----------");
            Exercise3();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 4:");
            Console.WriteLine("-----------");
            Exercise4();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 5:");
            Console.WriteLine("-----------");
            Exercise5();

            Console.WriteLine();
            Console.WriteLine("--- DONE!");
            Console.ReadKey();
        }

        static void Exercise1()
        {
            // INPUT

            // PROCESSING

            // OUTPUT
            Console.WriteLine("Centennial College - Progress Campus \nAddress: 941 Progress Ave, Scarborough, ON M1G 3T8");
        }

        static void Exercise2()
        {
            // INPUT     

            Console.Write("Which coffee drink do you want? ");
            string coffeeType = Console.ReadLine();

            Console.Write("How much is the coffee drink? ");
            double coffeeCost = Convert.ToDouble(Console.ReadLine());

            // PROCESSING

            double workDays = 6 * 4;
            double monthlyCost = workDays * coffeeCost; 

            // OUTPUT
            Console.WriteLine($"The Drink you have chosen: {coffeeType} \nThe Monthly Cost: ${monthlyCost}");
        }

        static void Exercise3()
        {
            // INPUT
            Console.Write("Enter the letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            // PROCESSING

            int number = Convert.ToInt32 (letter);

            int output = number / 2; 

            // OUTPUT
            Console.Write($"Char: {letter} \nResult: {output}");
        }

        static void Exercise4()
        {
            // INPUT

            Console.Write("Please enter your home planet: ");
            string prompt = Console.ReadLine();

            string homePlanet = prompt.ToUpper(); 

            // PROCESSING

            if (homePlanet == "MARS")
                Console.Write($"{prompt}. You are a Martian, and you have 5 toes");
            else
                if (homePlanet == "VENUS")
                Console.Write($"{prompt}. You are a Venusian, and you have 10 toes");
            else
                if (homePlanet == "MERCURY")
                Console.Write($"{prompt}. You are a Mercurian, and you have 15 toes");
            else
                Console.Write("Unknown Planet");

            // OUTPUT
        }

        static void Exercise5()
        {
            // INPUT
      

            Console.Write("Please enter your home planet: "); 
            string prompt = Console.ReadLine();

            string homePlanet = prompt.ToUpper();

            // PROCESSING

            // OUTPUT

            switch (homePlanet.ToUpper())
            {
                case "MARS":
                    Console.WriteLine($"{prompt}. You are a Martian, and you have 5 toes");
                    break;
                case "VENUS":
                    Console.WriteLine($"{prompt}. You are a Venusian, and you have 10 toes");
                    break;
                case "MERCURY":
                    Console.WriteLine($"{prompt}. You are a Mercurian, and you have 15 toes");
                    break;
                default:
                    Console.WriteLine($"Unknown Planet");
                    break;
            }
        }
    }
}