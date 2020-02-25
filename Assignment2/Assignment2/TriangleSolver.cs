using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideOne, int sideTwo, int sideThree)
        {
            if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo ||
                            sideTwo + sideThree <= sideOne)
            {
                Console.WriteLine("These side can not make triangle");
                return "false";
            }
            else
            {
                Console.WriteLine("These sides can make a triangle");
                if (equilateralTriangle(sideOne, sideTwo, sideThree) == true)
                {
                    Console.WriteLine("This is Equilateral triangle");
                }
                else if (isoscelesTriangle(sideOne, sideTwo, sideThree) == true)
                {
                    Console.WriteLine("This is isosceles triangle");
                }
                else if (scaleneTriangle(sideOne, sideTwo, sideThree) == true)
                {
                    Console.WriteLine("This is scalene triangle");
                }

                return "True";
            }

        }

        public static Boolean equilateralTriangle(int sideOne, int sideTwo, int sideThree)
        {
            if (sideOne == sideTwo && sideTwo == sideThree)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean isoscelesTriangle(int sideOne, int sideTwo, int sideThree)
        {
            if ((sideOne == sideTwo) || (sideTwo == sideThree) || (sideOne == sideThree))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean scaleneTriangle(int sideOne, int sideTwo, int sideThree)
        {
            if ((sideOne != sideTwo) || (sideTwo != sideThree) || (sideOne != sideThree))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
