using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, originalNumber, reverseNumber = 0, reminder;
            Console.Write("Enter A Number : ");
            number = int.Parse(Console.ReadLine());
            originalNumber = number;
            while(number != 0)
            {
                reminder = number % 10;
                reverseNumber = (reverseNumber * 10) + reminder;
                number /= 10;
            }
            if (originalNumber == reverseNumber)
            {
                Console.WriteLine(originalNumber + " it is a palindrome number");
            }
            else Console.WriteLine(originalNumber + " it is not a palindrome number");
            Console.ReadKey();
        }
       
    }
}
