using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, temp,counter=0;
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            int number2 = number / 2;

            if (number == 1)
            {
                Console.WriteLine(number+" NEITHER PRIME NOR COMPOSITE");
            }
            else if(number <= 0)
            {
                Console.WriteLine(number + " This is not a prime number");
            }
            else
            {
                for (int count = 2; count < number2; count++)
                {
                    temp = number % count;
                    if (temp == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.Write(number+" is a prime number");
                }
                else
                {
                    Console.WriteLine(number+" is not a prime number");
                }
            }
            Console.ReadKey();
           
        }
     

    }
}
