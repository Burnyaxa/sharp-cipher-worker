using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Cipher
{
    class VigenereCipher : IChiper
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
            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var q = alphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = alphabet.IndexOf(text[i]);
                var codeIndex = alphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    //если буква не найдена, добавляем её в исходном виде
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += alphabet[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            return retValue;
        }

        string IChiper.Encrypt(string text, string key)
        {
            return Vigenere(text, key);
        }

        string IChiper.Decrypt(string text, string key)
        {
            return Vigenere(text, key);
        }
    }
}
