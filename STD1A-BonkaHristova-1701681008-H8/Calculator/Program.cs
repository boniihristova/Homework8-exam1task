using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNum;
            float secondNum;
            char operation;
            string answer;


            do
            {
                Console.Write("Do you want calculate some numbers? yes or no ");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.Write("Enter the first number  ");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number");
                    secondNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter your operation ( x , / , +, -) ");
                    operation = char.Parse(Console.ReadLine());


                    switch (operation)
                    {
                        case '+':
                            double plusResult = (firstNum + secondNum)  * 1.1;
                            Console.WriteLine("The result is{0}", Math.Round(plusResult, 2));
                            break;
                        case '-':
                            double maxNumber, minNumber;
                            if (firstNum > secondNum)
                            {
                                maxNumber = firstNum;
                                minNumber = secondNum;

                            }
                            else
                            {
                                maxNumber = secondNum;
                                minNumber = firstNum;

                            }
                            double minusResult = Math.Pow(maxNumber, 2) - minNumber;
                            Console.WriteLine("The result is{0}", Math.Round(minusResult, 2));
                            break;

                        case '*':
                            double result = firstNum * Math.Sqrt(secondNum);
                            Console.WriteLine("The result is{0}", Math.Round(result, 2));
                            break;
                        case '/':
                            if (secondNum == 0)
                            {
                                Console.WriteLine("You can't divide to 0!");
                            }
                            else
                            {
                                result = firstNum / secondNum;
                                Console.WriteLine("The result is{0}", Math.Round(result, 2));
                            }
                            break;
                    }
                }
            } while (true);


            }
        }
    }



       