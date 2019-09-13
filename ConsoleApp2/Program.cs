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
            Console.WriteLine("What is your  name:");
            string name = Console.ReadLine();

            Console.WriteLine("Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your address:");
            string address = Console.ReadLine();

            string details = name + " address: " + address + " age " + age;
            Console.WriteLine($"Your details is: {details}");

            Console.ReadKey();

        }
    }
}
