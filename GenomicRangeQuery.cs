namespace CodilityAnswers
{
    public class GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            var s = S.Length;
            var seq = new int[4, s];
            for (var i = 0; i < s; i++)
            {
                int previous = i == 0 ? 0 : i - 1;
                seq[0, i] = seq[0, previous] + (S[i] == 'A' ? 1 : 0);
                seq[1, i] = seq[1, previous] + (S[i] == 'C' ? 1 : 0);
                seq[2, i] = seq[2, previous] + (S[i] == 'G' ? 1 : 0);
                seq[3, i] = seq[3, previous] + (S[i] == 'T' ? 1 : 0);
            }

            var index = 0;
            var result = new int[P.Length];
            for (var k = 0; k < P.Length; k++)
            {
                if (P[k] == 0)
                {
                    if (seq[0, Q[k]] > 0) { result[index++] = 1; continue; }
                    if (seq[1, Q[k]] > 0) { result[index++] = 2; continue; }
                    if (seq[2, Q[k]] > 0) { result[index++] = 3; continue; }
                    if (seq[3, Q[k]] > 0) { result[index++] = 4; }
                }
                else
                {
                    if (seq[0, Q[k]] - seq[0, P[k] - 1] > 0) { result[index++] = 1; continue; }
                    if (seq[1, Q[k]] - seq[1, P[k] - 1] > 0) { result[index++] = 2; continue; }
                    if (seq[2, Q[k]] - seq[2, P[k] - 1] > 0) { result[index++] = 3; continue; }
                    if (seq[3, Q[k]] - seq[3, P[k] - 1] > 0) { result[index++] = 4; }
                }
            }

            return result;
        }
    }
}
