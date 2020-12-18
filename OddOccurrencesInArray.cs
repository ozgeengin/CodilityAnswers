using System.Linq;

namespace CodilityAnswers
{
    class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            return A.GroupBy(x => x)
                .Select(y => new { y.Key, Count = y.Count() })
                .Where(z => z.Count % 2 == 1)
                .Select(x => x.Key)
                .FirstOrDefault();
        }
    }
}
