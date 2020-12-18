using System;
using System.Linq;

namespace CodilityAnswers
{
    internal class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            var len = A.Length;
            switch (len)
            {
                case 1:
                    return A[0];
                case 2:
                    return Math.Abs(A[0] - A[1]);
            }

            var minDiff = int.MaxValue;
            var left = 0;
            var right = A.Sum();

            for (var i = 0; i < len - 1; i++)
            {
                left += A[i];
                right -= A[i];
                minDiff = Math.Min(Math.Abs(left - right), minDiff);
                if (minDiff == 0)
                {
                    return 0;
                }
            }

            return minDiff;
        }
    }
}