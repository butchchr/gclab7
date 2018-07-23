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

            if (IsNOW(name) && (IsName(name)))
            {
                Console.WriteLine("I love the name " + name + "!");
            }

            else
            {
                Console.WriteLine("Sorry, name is not valid");
            }

            Console.WriteLine("Please enter your email address in the form helloworld@email.com:");
            string email = Console.ReadLine();

            if (IsNOW(email) && (IsEmail(email)))
            {
                Console.WriteLine(email + " looks like a valid email address to me");
            }
            else
            {
                Console.WriteLine("Sorry your email is not valid");
            }


            Console.WriteLine("Please enter your phone number in the form 123-456-7890:");
            string phone = Console.ReadLine();

            if (IsNOW(phone) && (IsPhone(phone)))
            {
                Console.WriteLine(phone + " you say? I'll have my modem call your people");
            }
            else
            {
                Console.WriteLine("Sorry your phone is not valid");
            }

            Console.WriteLine("Please enter a date in the form dd/mm/yyyy:");
            string date = Console.ReadLine();
            
            if (IsNOW(date) && (IsDate(date)))
            {
                Console.WriteLine(date + " That's my favorite day!");
            }
            else
            {
                Console.WriteLine("Sorry your date is not valid");
            }
            Console.ReadKey();
        }

        //method to check for null or white space
        static bool IsNOW(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        static bool IsName(string name)
        {
            //a-z only 1-30 start with capital
            return Regex.IsMatch(name, ("^[A-Z]{1}[a-z]{1,30}$"));
        }

        static bool IsEmail(string email)
        {
            // {A9 5 <= email <= 30} @ {A9 5 <= website <= 10} . {A9 2 <= com <= 3}
            return Regex.IsMatch(email, (@"(\w{5,30})@(\w{5,10}).(\w{2,3})"));
        }

        static bool IsPhone(string phone)
        {
            //# only 123-456-7890
            return Regex.IsMatch(phone, (@"(\d{3})-(\d{3})-(\d{4})$"));
        }

        static bool IsDate(string date)
        {
            //dd/mm/yyyy
            return Regex.IsMatch(date, (@"^(\d{2})/(\d{2}/)(\d{4})$"));
        }
    }
}
