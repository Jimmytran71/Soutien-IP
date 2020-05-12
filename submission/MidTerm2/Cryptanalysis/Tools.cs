using System;

namespace Cryptanalysis
{
    public static class Tools
    {
        public static int Modulus(int a, int b)
        {
            if (b < 0)
                b = -b;
        
            var mod = a % b;
            return mod < 0 ? b + mod : mod;
        }

        public static int LetterIndex(char c)
        {
            int res = ((int) c);
            if (res >= 65 && res <= 90)
            {
                return res - 65;
            }

            if (res >= 97 && res <= 122 )
            {
                return res - 97;
            }
            else
            {
                return -1;
            }
        }

        public static char RotChar(char c, int n)
        {
            int tmp = c;
            if ('0' <= c && c <= '9')
            {
                return c;
            }

            if ('A' <= c && c <= 'Z')
            {
                if (n < 0)
                    n = n % 26 + 26;
                tmp = (c - 'A' + n % 26) % 26 + 'A';
                tmp += (tmp > 'Z' ? tmp - 26 : (tmp < 'A' ? tmp + 26 : 0));
            }

            if ('a' <= c && c <= 'z')
            {
                if (n < 0)
                    n = n % 26 + 26;
                tmp = (c - 'a' + n % 26) % 26 + 'a';
                tmp += (tmp > 'z' ? tmp - 26 : (tmp < 'a' ? tmp + 26 : 0));
            }

            c = (char) tmp;
            return c;
        }

        public static int[] Histogram(string str)
        {
            int[] res = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                int chpos = LetterIndex(str[i]);
                if (chpos != -1)
                {
                    res[chpos] += 1;
                }
            }

            return res;
        }
    
        public static string FilterLetters(string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (LetterIndex(str[i]) != -1)
                {
                    res += str[i];
                }
            }

            return res;
        }

        public static string Extract(string str, int start, int step)
        {
            string res = "";
            for (int i = start; i < str.Length; i += step)
            {
                res += str[i];
            }

            return res;
        }
        
    }
}