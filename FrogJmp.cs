using System;

namespace CodilityAnswers
{
    internal class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            if (X == Y)
            {
                return 0;
            }

            var distance = Y - X;
            if (distance < D)
            {
                return 1;
            }

            int remainder = 0;
            var divider = Math.DivRem(distance, D, out remainder);

            return remainder == 0 ? divider : divider + 1;
        }
    }
}