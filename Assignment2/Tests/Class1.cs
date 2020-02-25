using Assignment2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void scaleneTriangle_input524_expectedResultTestpass()
        {
            int sideOne = 5;
            int sideTwo = 2;
            int sideThree = 4;

            bool test = TriangleSolver.scaleneTriangle(sideOne, sideTwo, sideThree);

            Assert.IsTrue(test);
        }

        [Test]
        public void isosclesTriangle_input828_expectedResultTestPass()
        {
            int sideOne = 8;
            int sideTwo = 2;
            int sideThree = 8;

            bool test = TriangleSolver.isoscelesTriangle(sideOne, sideTwo, sideThree);

            Assert.IsTrue(test);
        }

        [Test]
        public void equilateralTriangle_input555_expectedResultTestPass()
        {
            int sideOne = 5;
            int sideTwo = 5;
            int sideThree = 5;

            bool test = TriangleSolver.equilateralTriangle(sideOne, sideTwo, sideThree);

            Assert.IsTrue(test);
        }

        [Test]
        public void checkForTriangle_input000_expectedResultFalse()
        {
            int sideOne = 0;
            int sideTwo = 0;
            int sideThree = 0;

            string test = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
            Assert.Pass(test);
        }

        [Test]
        public void checkForTriangle_input453_expectedResultTrue()
        {
            int sideOne = 4;
            int sideTwo = 5;
            int sideThree = 3;

            string test = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
            Assert.Pass(test);
        }

        [Test]
        public void isosclesTriangle_input224_expectedResultTestPass()
        {
            int sideOne = 2;
            int sideTwo = 2;
            int sideThree = 4;

            bool test = TriangleSolver.isoscelesTriangle(sideOne, sideTwo, sideThree);

            Assert.IsTrue(test);
        }
    }
}
