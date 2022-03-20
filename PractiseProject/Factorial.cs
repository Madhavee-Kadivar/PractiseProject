using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    class Factorial
    {
        public static int no, fact=1;

        public static void FindFactorial()
        {
            Console.WriteLine("Enter Any you want to get factorial : ");
            no = Convert.ToInt32(Console.ReadLine());

            if (no == 0 || no == 1)
            {
                Console.WriteLine($"Factorial of {no} is : 1");
            }
            else
            {
                for (int i = 1; i <= no; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine($"Factorial of {no} is : {fact}");
            }
           
        }
    }
}
