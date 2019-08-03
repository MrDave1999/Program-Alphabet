using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetProgram
{
    class BBinary
    {
        public static int BBIterative<T>(T[] pv, T data) where T : IComparable<T>
        {
            int first = 0;
            int end = pv.Length - 1;
            int medium;
            int i = 0;
            while (first <= end)
            {
                ++i;
                medium = (first + end) / 2;
                if (pv[medium].CompareTo(data) == 0)  //pv[medium] == data
                    return medium;
                if (data.CompareTo(pv[medium]) > 0) //data > pv[medium]
                    first = medium + 1;
                else
                    end = medium - 1;
            }
            return -1;
        }
    }
}
