using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Cipher
{
    class CaesarCipher : ICipher
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private string CodeEncode(string text, int k)
        {
            string fullAlphabet = alphabet + alphabet.ToLower();
            int letterQty = fullAlphabet.Length;
            string retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int index = fullAlphabet.IndexOf(c);
                if (index < 0)
                {
                    retVal += c.ToString();
                }
                else
                {
                    int codeIndex = (letterQty + index + k) % letterQty;
                    retVal += fullAlphabet[codeIndex];
                }
            }

            return retVal;
        }

        string ICipher.Decrypt(string text, string key)
        {
            return CodeEncode(text, -Convert.ToInt32(key));
        }

        string ICipher.Encrypt(string text, string key)
        {
            return CodeEncode(text, Convert.ToInt32(key));
        }
    }
}
