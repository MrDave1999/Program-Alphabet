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

        public char[] Abc
        {
            get { return abc; }
        }

        public int[] CountUpper
        {
            get { return countUpper; }
            set { countUpper = value; }
        }

        public int[] CountLower
        {
            get { return countLower; }
            set { countLower = value; }
        }
    }
}
