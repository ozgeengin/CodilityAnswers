using System;

namespace CodilityAnswers
{
    internal class PermMissingElem
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return A.Length + 1;
        }
    }
}