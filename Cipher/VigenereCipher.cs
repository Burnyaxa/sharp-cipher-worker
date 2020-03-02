using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Cipher
{
    class VigenereCipher : ICipher
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }

        private string Vigenere(string text, string password, bool encrypting = true)
        {
            string fullAlphabet = alphabet + alphabet.ToLower();
            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var q = fullAlphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = fullAlphabet.IndexOf(text[i]);
                var codeIndex = fullAlphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += fullAlphabet[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            return retValue;
        }

        string ICipher.Encrypt(string text, string key)
        {
            return Vigenere(text, key);
        }

        string ICipher.Decrypt(string text, string key)
        {
            return Vigenere(text, key, false);
        }
    }
}
