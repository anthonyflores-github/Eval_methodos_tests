using System;
using System.Collections.Generic;

namespace Test_cours
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class Program1
    {
        public static void Main()
        {
        }

        public static string JoinString(List<String> listToConcat, String separator)
        {
            String concatenate = "";
            if (listToConcat.Count == 0)
            {
                return concatenate;
            }
            else
            {
                foreach (String element in listToConcat)
                {
                    concatenate += element;
                    concatenate += separator;
                }
                if (separator == " ")
                {
                    concatenate = concatenate.Substring(0, concatenate.Length - 1);
                }
                return concatenate;
            }
        }

        public static int Average(List<int> listInt)
        {
            int concatenate = 0;
            if (listInt.Count == 0)
            {
                return concatenate;
            }
            else
            {
                foreach (int element in listInt)
                {
                    concatenate += element;
                }
                concatenate = concatenate / listInt.Count;
                return concatenate;
            }
        }
    }
}