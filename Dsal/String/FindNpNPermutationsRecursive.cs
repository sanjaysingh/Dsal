using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.String
{
    public static class FindNpNPermutationsRecursiveExtensions
    {
        public static IEnumerable<string> FindNpNPermutationsRecursive(this string data)
        {
            foreach(string permutation in FindNpNPermutationsRecursive(data, string.Empty))
            {
                yield return permutation;
            }
        }

        private static IEnumerable<string> FindNpNPermutationsRecursive(string substring, string remaining)
        {
            if (string.IsNullOrEmpty(substring)) yield return remaining;
            for (int i = 0; i < substring.Length; i++)
            {
                foreach (var permutation in FindNpNPermutationsRecursive(substring.Remove(i, 1), remaining + substring[i]))
                {
                    yield return permutation;
                }
            }
        }
    }
}
