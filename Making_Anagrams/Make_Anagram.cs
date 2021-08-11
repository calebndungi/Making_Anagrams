using System;
using System.Collections.Generic;

namespace Making_Anagrams
{
    public class Make_Anagram
    {
        public static int makeanagram(string a , string b)
        {
            char[] arra = a.ToCharArray();

            char[] arrb = b.ToCharArray();


            int deletions = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char c in arra)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }

            }

            foreach(char c in arrb)
            {
                if (!dict.ContainsKey(c))
                {
                    deletions++;
                }
            }

            return deletions;
        }
    }
}
