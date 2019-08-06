using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetProgram
{
    public class DetectAbc
    {
        private Alphabet alpha = new Alphabet();

        public Alphabet Alpha
        {
            get {return alpha; }
        }

        //Para recorrer la caja box.
        public void RecSentence(string sentence)
        {
            for (int i = 0, len = sentence.Length; i != len; ++i)
            {
                if ((sentence[i] >= 'a' && sentence[i] <= 'z') || (sentence[i] >= 'A' && sentence[i] <= 'Z'))
                    DetectUpperOrLower(sentence[i]);
            }
        }

        //Para detectar si la letra es mayúscula o minúscula.
        public void DetectUpperOrLower(char charx)
        {
            int pos;
            bool convertion = false;
            if (charx >= 'a' && charx <= 'z')
            {
                convertion = true;
                charx -= (char)32;
            }
            pos = BBinary.BBIterative<char>(alpha.Abc, charx);
            if (convertion)
                ++alpha.CountLower[pos]; 
            else
                ++alpha.CountUpper[pos];
        }

        //Para mostrar la cantidad de mayúsculas y minúsculas
        public double ShowCounts(ref int totLower, ref int totUpper)
        {
            for (int i = 0; i != 26; ++i)
            {
                totUpper += alpha.CountUpper[i];
                totLower += alpha.CountLower[i];
            }
            return (totUpper + totLower) / (double)2;
        }
    }
}
