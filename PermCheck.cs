﻿using System;

namespace CodilityAnswers
{
    internal class PermCheck
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}