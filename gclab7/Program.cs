using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gclab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User: Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your email address in the form helloworld@email.com:");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your phone number in the form (123) 456-7890:");
            string phone = Console.ReadLine();

            Console.WriteLine("Please enter a date in the form dd/mm/yyyy:");
            string date = Console.ReadLine();

            if (IsName(name))
            {
                Console.WriteLine(name);
            }

            else

            {
                Console.WriteLine("Sorry, name is not valid");
            }

            if (IsEmail(email))
            {
                Console.WriteLine(email);
            }
            else
            {
                Console.WriteLine("Sorry your email is not valid");
            }

            if (IsPhone(phone))
            {
                Console.WriteLine(phone);
            }
            else
            {
                Console.WriteLine("Sorry your phone is not valid");
            }

            if (IsDate(date))
            {
                Console.WriteLine(date);
            }
            else
            {
                Console.WriteLine("Sorry your date is not valid");
            }
            Console.ReadKey();
        }


        static bool IsName(string name)
        {
            //a-z only 1-30 start with capital
            return true;
        }

        static bool IsEmail(string email)
        {
            // {A# 5 <= email <= 30} @ {A# 5 <= website <= 10} . {A# 2 <= com <= 3}
            return true;
        }

        static bool IsPhone(string phone)
        {
            //# only (123) 456-7890
            return true;
        }

        static bool IsDate(string date)
        {
            //dd/mm/yyyy
            return true;
        }

    }
}
