using lab1cipher.Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Encoder
{
    class VigenereEncoder : Encoder
    {
        public VigenereEncoder(string text, string key) : base(text, key) { }

        public override EncodedMessage Create(string text, string key)
        {
            ICipher vigenere = new VigenereCipher();
            string encoded = vigenere.Encrypt(text, key);
            return new VigenereEncodedMessage(encoded);
        }
    }
}
