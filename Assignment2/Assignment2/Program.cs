using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number from below");
            Console.WriteLine("1.Enter Triangle dimention");
            Console.WriteLine("2. Exit");

            string userInput = Console.ReadLine();
            string inputOne, inputTwo, inputThree;

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Please enter 1st side of triangle.");
                    inputOne = Console.ReadLine();
                    Console.WriteLine("Please enter 2nd side of triangle.");
                    inputTwo = Console.ReadLine();
                    Console.WriteLine("Please enter 3rd side of triangle.");
                    inputThree = Console.ReadLine();
                    //if (TriangleSolver.Analyze(sideOne,sideTwo,sideThree))
                    //{

                    //}
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select a number from below");
                    Console.WriteLine("1.Enter Triangle dimention");
                    Console.WriteLine("2. Exit");
                    break;


            }
        }
    }
}
