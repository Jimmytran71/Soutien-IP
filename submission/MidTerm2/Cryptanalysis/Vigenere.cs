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
            for (int i = 0; i < msg.Length; i++)
            {
                int index = Tools.LetterIndex(msg[i]);
                if (index != -1)
                {
                    ind[i] = index;
                }
            }

            for (int i = 0; i < ind.Length; i++)
            {
                rep += Tools.RotChar(msg[i], ind[i]);
            }

            return rep;
        }

        public string Decrypt(string cypherText)
        {
            throw new NotImplementedException();
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