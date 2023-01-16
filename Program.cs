using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" chooes option\n1. Find maximum among 3 integers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    MaximumNumber maximumNumber = new MaximumNumber();
                    int intValue = maximumNumber.PrintIntegerMaximumNumber(89,45,25);
                    Console.WriteLine("Maximum number among these integers is " + intValue);
                    break;
            }
            Console.ReadLine();
        }
    }
}
