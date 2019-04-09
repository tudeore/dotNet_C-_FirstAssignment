using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {

        static void Main(string[] args)
        {

            {
                int numberOne;
                int numberTwo;
                Console.WriteLine("Select From List");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.divion");
                int choice = int.Parse(Console.ReadLine());
                void input()
                {
                    Console.WriteLine("enter first number");
                    numberOne = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter second Number");
                    numberTwo = int.Parse(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                        input();
                        Console.WriteLine("addition of two Numbers = " + (numberOne + numberTwo));
                        break;
                    case 2:
                        input();
                        Console.WriteLine("subtraction of two numbers = " + (numberOne - numberTwo));
                        break;
                    case 3:
                        input();
                        Console.WriteLine("multiplication Of Two numbers = " + (numberOne * numberTwo));
                        break;
                    case 4:
                        input();
                        Console.WriteLine("division of Two numbers = " + (numberOne / numberTwo));
                        break;
                    case 5: break;
                }

                Console.ReadKey();

            }

        }
    }
}
