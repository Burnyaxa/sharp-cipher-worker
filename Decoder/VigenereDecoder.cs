using lab1cipher.Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Decoder
{
    class VigenereDecoder : Decoder
    {
        public VigenereDecoder(string text, string key) : base(text, key) { }

        public override DecodedMessage Create(string text, string key)
        {
            ICipher vigenere = new VigenereCipher();
            string decoded = vigenere.Decrypt(text, key);
            return new VigenereDecodedMessage(decoded);
        }
    }
}
