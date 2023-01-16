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
            Console.WriteLine(" chooes option\n1. Find maximum among 3 integers\n2. Find maximum among 3 float numbers\n3. Find maximum among 3 string values");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    MaximumNumber maximumNumber = new MaximumNumber();
                    int intValue = maximumNumber.PrintIntegerMaximumNumber(89,45,25);
                    Console.WriteLine("Maximum number among these integers is " + intValue);
                    break;
                case 2:
                    MaximumFloatNumber maximumFloatNumber = new MaximumFloatNumber();
                    float floatValue = maximumFloatNumber.PrintFloatMaximumNumber(26.5f, 12.9f, 225.07f);
                    Console.WriteLine("Maximum float number among these float numbers is " + floatValue);
                    break;
                case 3:
                    MaximumString maximumString = new MaximumString();
                    string strvalue = maximumString.PrintMaximumString("Apple", "Banana", "Peach");
                    Console.WriteLine("Maximum string among these string values is " + strvalue);
                    break;
            }
            Console.ReadLine();
        }
    }
}
