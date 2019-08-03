using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetProgram
{
    public class DetectAbc
    {
        private Alphabet abc = new Alphabet();
        private int[] countUpper;
        private int[] countLower;

        public Alphabet getAbc()
        {
            return abc;
        }

        public void RecSentence(string sentence)
        {
            countUpper = abc.getCountUpper();
            countLower = abc.getCountLower();
            for (int i = 0, len = sentence.Length; i != len; ++i)
            {
                if ((sentence[i] >= 'a' && sentence[i] <= 'z') || (sentence[i] >= 'A' && sentence[i] <= 'Z'))
                    DetectUpperOrLower(sentence[i]);
            }
        }

        public void DetectUpperOrLower(char charx)
        {
            int pos;
            bool convertion = false;
            if (charx >= 'a' && charx <= 'z')
            {
                convertion = true;
                charx -= (char)32;
            }
            pos = BBinary.BBIterative<char>(abc.getAbc(), charx);
            if (convertion)
                ++countLower[pos];
            else
                ++countUpper[pos];
        }

        public double ShowCounts(ref int totLower, ref int totUpper)
        {
            for (int i = 0; i != 26; ++i)
            {
                totUpper += countUpper[i];
                totLower += countLower[i];
            }
            return (totUpper + totLower) / 2.0;
        }
    }
}
