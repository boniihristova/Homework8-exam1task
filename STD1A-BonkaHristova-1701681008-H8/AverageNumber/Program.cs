using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int x = 0;
            int average;
            int counter = 0;
            do
            {
                Console.WriteLine("Enter number:");
                number = int.Parse(Console.ReadLine());
                if (number >= 1 && number <= 255)
                {
                    if (number % 2 == 0)
                    {
                        
                        x = x + number;
                        counter++;

                    }
                }
        

            } while (number != 0);
             if (counter== 0) 
            {
                Console.WriteLine("There aren't  even numbers in this diapason [1,255]");
               
            }
             else
            {
                average = x / counter;
                Console.WriteLine("Finished!");
                Console.WriteLine("Average number is {0}", average);
            }
        }
    }
}

          
                

            





         
     