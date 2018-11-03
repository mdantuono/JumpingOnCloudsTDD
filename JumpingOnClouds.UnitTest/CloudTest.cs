using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnClouds.UnitTest
{
    public class CloudTest
    {
        [Test]
        public void returnsAnInteger()
        {
            int[] cloudArray = new int[] { };

            var cloudJumps = new CloudJumps();

            int ourInteger = cloudJumps.FindNumberOfJumps(cloudArray);

            bool ourIntegerIsAnInteger = (ourInteger.GetType() == typeof(int));

            bool numberIsAnInteger = true;

            Assert.AreEqual(ourIntegerIsAnInteger, numberIsAnInteger);

        }

        [Test]
        public void FindNumberOfJumpsShouldReturnFour()
        {
            const int numberOfClouds = 7;
            int[] cloudArray = new int[numberOfClouds] { 0, 0, 1, 0, 0, 1, 0 };
            var expectedResult = 4;

            var cloudJumps = new CloudJumps();

            int result = cloudJumps.FindNumberOfJumps(cloudArray);

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void FindNumberOfJumpsShouldReturnThree()
        {
            const int numberOfClouds = 6;
            int[] cloudArray = new int[numberOfClouds] { 0, 0, 0, 0, 1, 0 };
            var expectedResult = 3;

            var cloudJumps = new CloudJumps();

            int result = cloudJumps.FindNumberOfJumps(cloudArray);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FindNumberOfJumpsShouldReturnThreeAgain()
        {
            const int numberOfClouds = 6;
            int[] cloudArray = new int[numberOfClouds] { 0, 0, 0, 1, 0, 0 };
            var expectedResult = 3;

            var cloudJumps = new CloudJumps();

            int result = cloudJumps.FindNumberOfJumps(cloudArray);

            Assert.AreEqual(expectedResult, result);

        }

    }
}
