using System;

namespace CodilityAnswers
{
    internal class MissingInteger
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int result = 1;
            foreach (var n in A)
            {
                if (n > 0)
                {
                    result = n != result ? result : result + 1;
                }
            }

            return result;
        }
    }
}