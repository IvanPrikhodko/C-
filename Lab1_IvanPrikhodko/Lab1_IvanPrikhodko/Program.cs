// See https://aka.ms/new-console-template for more information


using System;

//Ivan Prikhodko 301261209

namespace Lab1 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // INPUT

            int numChildTicket , numAdultTicket;

            double childTicketCost = 3.75, adultTicketCost = 2.25;
            
            string childPrompt = "Enter number of children:", adultPrompt = "Enter number of adults:"; 

            bool isCSharpFun = true;

            Console.WriteLine("****************************************************");
            Console.WriteLine("Welcome to Canada's Wonderland!");
            Console.WriteLine("Please enter the number of tickets you would like.");
            Console.WriteLine("One adult ticket is $3.75 and one child ticket is $2.25.");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine(childPrompt);
            numChildTicket = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(adultPrompt);
            numAdultTicket = Convert.ToInt16(Console.ReadLine());

            // PROCESSING

            double totalPrice;
            int totalTickets;

            totalPrice = numChildTicket*childTicketCost + numAdultTicket*adultTicketCost;
            totalTickets = numAdultTicket + numChildTicket; 

            // OUTPUT

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"Your total number of tickets is {totalTickets}, and your ticket price is {totalPrice:C}");
            Console.WriteLine("");
            Console.WriteLine("****************************************************");

            Console.WriteLine($"C# is fun abd that is {isCSharpFun} !");


        }
    }
}
