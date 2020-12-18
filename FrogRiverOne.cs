using System.Collections.Generic;

namespace CodilityAnswers
{
    internal class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            Dictionary<int, bool> river = new Dictionary<int, bool>();
            var result = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] <= X && !river.ContainsKey(A[i]))
                {
                    river.Add(A[i], true);
                    result++;
                }

                if (result == X)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}