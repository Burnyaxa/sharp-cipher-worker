using lab1cipher.Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Encoder
{
    class CaesarEncoder : Encoder
    {
        public CaesarEncoder(string text, string key) : base(text, key) { }

        public override EncodedMessage Create(string text, string key)
        {
            ICipher caesar = new CaesarCipher();
            string encoded = caesar.Encrypt(text, key);
            return new CaesarEncodedMessage(encoded);
        }
    }
}
