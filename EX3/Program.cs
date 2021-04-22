using System;
using System.Collections.Generic;

namespace Test_cours
{
    /// <summary>
    /// demo class.
    /// </summary>
    public class Program3
    {
        public static String automaticLineBreaks(string sentence, int len)
        {
            string sentenceResult = "";

            string ligne = "";

            foreach (string element in sentence.Split(" "))
            {
                foreach (string element2 in sentenceResult.Split("/n"))
                {
                    ligne = element2;
                }
                if (ligne == "")
                {
                    sentenceResult += element;
                }
                else
                {
                    if (ligne.Length + element.Length <= len)
                    {
                        sentenceResult = sentenceResult + " " + element;
                    }
                    else
                    {
                        sentenceResult = sentenceResult + "\n" + element;
                    }
                }
            }
            return sentenceResult;
        }
    }
}
