using System;

namespace Cryptanalysis
{
    public class Vigenere
    {
        public const float FrenchIndexOfCoincidence = 0.0778F;
        private string key;
        public Vigenere(string key)
        {
            this.key = key;
        }

        public string Encrypt(string msg)
        {
            string rep = "";
            int[] ind = new int[msg.Length];
            int keyind = 0;
            for (int i = 0; i < msg.Length; i++)
            {
                int index = Tools.LetterIndex(key[keyind]);
                if (index != -1 && Tools.LetterIndex(msg[i]) != -1)
                {
                    ind[i] = index;
                    keyind += 1;
                }
                
                rep += Tools.RotChar(msg[i], ind[i]);
                
                if (keyind == key.Length)
                {
                    keyind = 0;
                }
            }
            

            return rep;
        }

        public string Decrypt(string cypherText)
        {
            string rep = "";
            int[] ind = new int[cypherText.Length];
            int keyind = 0;
            for (int i = 0; i < cypherText.Length; i++)
            {
                int index = Tools.LetterIndex(key[keyind]);
                if (index != -1 && Tools.LetterIndex(cypherText[i]) != -1)
                {
                    ind[i] = index;
                    keyind += 1;
                }
                
                rep += Tools.RotChar(cypherText[i], -ind[i]);
                
                if (keyind == key.Length)
                {
                    keyind = 0;
                }
            }
            

            return rep;
        }

        public static string GuessKeyWithLength(string cypherText, int keyLength)
        {
            throw new NotImplementedException();
        }
    
        public static float IndexOfCoincidence(string str)
        {
            throw new NotImplementedException();
        }

        public static int GuessKeyLength(string cypherText)
        {
            throw new NotImplementedException();
        }
    
        public static string GuessKey(string cypherText)
        {
            throw new NotImplementedException();
        }
    }
}