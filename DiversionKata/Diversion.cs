using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiversionKata
{
    public class Diversion
    {
        public int CountBinarySequencesWithoutAdjacentOnes(int n)
        {
            int ends_with_0 = 1;
            int ends_with_1 = 1;

            for (int i = 1; i < n; i++)
            {
                int prev_ends_with_0 = ends_with_0;
                int prev_ends_with_1 = ends_with_1;
                ends_with_0 = prev_ends_with_0 + prev_ends_with_1;
                ends_with_1 = prev_ends_with_0;
            }

            return ends_with_0 + ends_with_1;
        }
    }
}
