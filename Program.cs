using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t                                            ");
            Console.WriteLine("\t\tWelcome to my odd and even numbers program: ");
            Console.WriteLine("\t\t............................................");
            Console.WriteLine("Enter number you want to check: ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int divisors = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % 1 == 0)
                {
                    divisors++;
                }
            }
            if(divisors == 0)
            {
                Console.WriteLine("The entered number is a prime number:");
            }
            else
            {
                Console.WriteLine("The entered number is not a prime number:");
            }
            Console.ReadLine();
        }
    }
}

