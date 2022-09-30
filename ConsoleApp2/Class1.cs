using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int Y = Convert.ToInt32(Console.ReadLine());
            if (Y % 4 == 0)
            {
                Console.WriteLine("this year is leap year");


            }
            else
            {
                Console.WriteLine("this year is not a leap year ");
            }
        }
    }
}





