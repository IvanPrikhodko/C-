using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Ivan Prihodko 301261209

namespace comp100_test02
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
            Console.WriteLine("--- DONE!");
            Console.ReadKey();
        }

        static void Exercise1()
        {
            // INPUT
            int i;
            int square;
            int cube;


            Console.WriteLine("Number\tSquare\tCube\n"); 
            // PROCESSING
            for(i=10;i>0;i--)
            {
                square = i * i;
                cube = i * i * i;

                Console.WriteLine($" {i}\t {square}\t {cube}\n ");  
            }
            // OUTPUT
        }

        static void Exercise2()
        {
            // INPUT

            int year = 1;
            decimal balance = 2000;
            decimal interest = 0.09m;

            Console.WriteLine("YEAR\t Balance\n" +
              "-------------------");
            // PROCESSING
            while (year < 11)
            {
                balance = balance * (1 + interest);

                decimal balance2 = Math.Round(balance, 2);
                Console.WriteLine(string.Format("{0,4}", year) + "\t" + $" {balance2}");
                year++;
            }
            // OUTPUT
        }

        static void Exercise3()
        {
            // INPUT

            int grade;
            int sum = 0;
            int validGrade = 0;
            int loop = 1;


            // PROCESSING
            do
            { 
                Console.WriteLine("Please enter grade between 0 and 100, enter 999 to terminate");
                grade = Convert.ToInt32(Console.ReadLine());

                if (grade == 999)
                {
                    loop = 0;
                }
                    else if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Invalid grade");
                    }
                        else if (grade > 0 && grade < 100)
                        {
                            Console.WriteLine($"You entered {grade}");
                            sum = sum + grade;
                            validGrade++;
                        }
            } while (loop != 0);

            // OUTPUT
            Console.WriteLine($"Your sum of the valid grades is {sum}\nYour number of the valid grades is {validGrade}\nYour average of the valid grades is {sum/validGrade}"); 
        }

        static void Exercise4()
        {
            // INPUT

            const int IVAN_PRIKHODKO = -7;
            double x, y; 

            Console.WriteLine("-----------------------------------------------------\n   x\t   2x^2\t    -x\t   -7\t    y\t      (x,y)\n-----------------------------------------------------");
            // PROCESSING
            for (x = 1; x <= 5; x = x + 0.5)
            {
               
                y = (2 * x * x) - (x) - IVAN_PRIKHODKO;
                Console.WriteLine("  " + string.Format("{0:0.0}", x) + "\t" 
                    + string.Format("{0,7:##.00}", 2*x*x) + "\t   " 
                    + string.Format("{0:0.0}", -x) 
                    + $"\t   {IVAN_PRIKHODKO}" + "\t   " 
                    + string.Format("{0,2}", y) 
                    + "\t   " + string.Format("{0,8:##.00}", $"({x},{y})"));
            }

            // OUTPUT
        }

    }
}
