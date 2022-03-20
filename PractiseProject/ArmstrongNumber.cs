using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class ArmstrongNumber
    {
        public static int num, sum = 0, actualnum, rem;

        public static void Armstrong()
        {
          
            Console.WriteLine("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            actualnum = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem*rem*rem);
                num = num / 10;
            }
            if (actualnum == sum)
            {
                Console.WriteLine($"{actualnum} is Armstrong Number");
            }
            else
            {
                Console.WriteLine($"{actualnum} is not a  Armstrong Number");
            }
        }
    }
}
