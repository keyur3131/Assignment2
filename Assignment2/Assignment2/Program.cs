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
            int value = 0;
            int inputOne;
            int inputTwo;
            int inputThree;
            do
            {
                
                Console.WriteLine("1.Enter Triangle dimention");
                Console.WriteLine("2. Exit");
                Console.Write("Please select a number from Above : ");

                try
                {
                    int userInput = int.Parse(Console.ReadLine());


                    if (userInput == 1)
                    {
                        Console.Write("Please enter side 1 for triangle : ");
                        inputOne = int.Parse(Console.ReadLine());
                        Console.Write("Please enter side 2 for triangle : ");
                        inputTwo = int.Parse(Console.ReadLine());
                        Console.Write("Please enter side 3 for triangle : ");
                        inputThree = int.Parse(Console.ReadLine());

                        string answer = Assignment2.TriangleSolver.Analyze(inputOne, inputTwo, inputThree);
                    }

                    else if(userInput == 2)
                    {
                        userInput = 1;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Plese enter valid number");
                 
                }
            } while (value == 0);
            
        }
    }
}
