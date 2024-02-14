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
    }
}
