using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class StringUtilities
    {
        public static int LongWordsCount(string input)
        {
            string[] words = input.Split(' ');
            int count = 0;
            foreach (string word in words)
            {
                if (word.Length > 2)
                {
                    count++;
                }
            }
            return count;
        }

        public static string ToSpinalCase(string input)
        {
            string[] words = input.Split(' ');
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                if (result.Length > 0)
                {
                    result.Append("-");
                }
                result.Append(word.ToLower());
            }
            return result.ToString();
        }
    }
}
