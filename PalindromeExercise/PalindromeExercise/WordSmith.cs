﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsPalindrome(string word)
        {
            if (word == null || word.Length == 0)
            {
            return false;

            }
            string reversword = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                reversword += word[i];
            }

            return word.ToLower() == reversword.ToLower();
        }
    }
}
