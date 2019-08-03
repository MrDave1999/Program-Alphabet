using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetProgram
{
    public class Alphabet
    {
        private char[] abc = new char[26];
        private int[] countUpper = new int[26];
        private int[] countLower = new int[26];

        public Alphabet()
        {
            for (int i = 0; i != 26; ++i)
                abc[i] = (char)(i + 'A');
        }

        public char[] getAbc()
        {
            return abc;
        }

        public int[] getCountUpper()
        {
            return countUpper;
        }

        public int[] getCountLower()
        {
            return countLower;
        }
    }
}
