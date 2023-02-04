using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] hoursWeekday = { "12 am: Off-Peak", "1 am: Off-peak", "2 am: Off-peak", "3 am: Off-peak", "4 am: Off-peak", "5 am: Off-peak", "6 am: Off-peak", "7 am: Off-peak", "8 am: Mid-peak", "9 am: Mid-peak",
            "10 am: Mid-peak","11 am: Mid-peak","12 pm: On-peak","1 pm: On-peak","2 pm: On-peak","3 pm: On-peak","4 pm: On-peak","5 pm: Off-peak","6 pm: Mid-peak",
            "7 pm: Off-peak","8 pm: Off-peak","9 pm: Off-peak","10 pm: Off-peak","11 pm: Off-peak"};
            string[] hoursWeekend = { "12 am: Off-Peak", "1 am: Off-peak", "2 am: Off-peak", "3 am: Off-peak", "4 am: Off-peak", "5 am: Off-peak", "6 am: Off-peak", "7 am: Off-peak", "8 am: Off-peak", "9 am: Off-peak",
            "10 am: Off-peak","11 am: Off-peak","12 pm: Off-peak","1 pm: Off-peak","2 pm: Off-peak","3 pm: Off-peak","4 pm: Off-peak","5 pm: Off-peak","6 pm: Off-peak",
            "7 pm: Off-peak","8 pm: Off-peak","9 pm: Off-peak","10 pm: Off-peak","11 pm: Off-peak"};
            
     
            //outer loop
            for (int i = 0;  i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);

                if (i < 5)
                {
                    for (int j = 0; j < hoursWeekday.Length; j++)
                    {

                        Console.WriteLine(hoursWeekday[j]);
                    }
            
            //inner loop
                }
                else if (i > 4)
                    {
                    for (int k = 0; k < hoursWeekend.Length; k++)
                    {
                        Console.WriteLine(hoursWeekend[k]);
                    }

                    }

                }           

            }
        
        }
    }

