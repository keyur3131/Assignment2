using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class TriangleSolver
    {
        public static int Analyze(int sideOne, int sideTwo, int sideThree)
        {
            if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo ||
                            sideTwo + sideThree <= sideOne)
            {
                return 0;
            }
            else
                return 1;
        }
    }
}
