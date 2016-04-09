using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.String
{
    public static class IsPalindromeExtension
    {
        public static bool IsPalindrome(this string data)
        {
            int start = 0, end = data.Length - 1;
            
            while (start < end && char.ToLower(data[start]) == char.ToLower(data[end]))
            {
                start++;
                end--;
            }

            return start >= end;
        }
    }
}
