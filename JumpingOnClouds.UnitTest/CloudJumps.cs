using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnClouds.UnitTest
{
    class CloudJumps
    {
        internal int FindNumberOfJumps(int[] cloudArray)
        {
            // Initialize jump counter
            int numberOfJumps = 0;

            for (var i = 0; i < cloudArray.Length - 1; i++)
            {
                if (cloudArray[i + 1] == 0)
                {
                    if (i + 1 < cloudArray.Length - 1 && cloudArray[i + 2] == 0)
                    {
                        numberOfJumps++;
                        i++;
                    }
                    else
                    {
                        numberOfJumps++;
                    }
                } else
                {
                    if (cloudArray[i + 2] == 0)
                    {
                        numberOfJumps++;
                        i++;
                    }
                }
            }

            return numberOfJumps;
        }
    }
}
