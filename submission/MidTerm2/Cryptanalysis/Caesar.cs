using System;

namespace Cryptanalysis
{
    public class Caesar
    {
        private int key;

        public int Key => key;

        public Caesar(int key)
        {
            this.key = key;
        }

        public string Encrypt(string msg)
        {
            string res = "";
            for (int i = 0; i < msg.Length; i++)
            {
                res += Tools.RotChar(msg[i], key);
            }

            return res;
        }

        public string Decrypt(string cypherText)
        {
            string res = "";
            for (int i = 0; i < cypherText.Length; i++)
            {
                res += Tools.RotChar(cypherText[i], - key);
            }

            return res;
        }
    
        public static int GuessKey(string cypherText)
        {
            int[] histo = Tools.Histogram(cypherText);
            int res = 0;
            for (int i = 0; i < histo.Length-1; i++)
            {
                if (histo[i] < histo[i+1])
                {
                    res = histo[i+1];
                }
            }

            return res - histo[4];
        }
    }
}