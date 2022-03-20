using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Practise Project");
            //Console.WriteLine("Adding just one line from local");
            //Console.WriteLine("Adding just one line from remote");
            //Console.WriteLine("Creating conflict from local");
            //Console.WriteLine("Creating conflict from remote");
            Human human = new Human();
            human.HumanDetails();
            Human.Speak();


            SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
            swapTwoNumbers.SwapNumbers();
           
            Console.Read();

        }
    }
}

