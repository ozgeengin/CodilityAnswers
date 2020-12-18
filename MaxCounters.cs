using System;

namespace CodilityAnswers
{
    internal class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            var result = new int[N];
            var max = 0;
            var totalMax = 0;
            foreach (var n in A)
            {
                if (n == N + 1)
                {
                    totalMax = max;
                }
                else
                {
                    result[n - 1] = result[n - 1] < totalMax ? totalMax + 1 : ++result[n - 1];
                    max = Math.Max(max, result[n - 1]);
                }
            }

            for (var i = 0; i < N; i++)
            {
                result[i] = result[i] < totalMax ? totalMax : result[i];
            }

            return result;
        }
    }
}