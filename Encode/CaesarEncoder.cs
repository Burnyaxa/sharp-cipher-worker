using lab1cipher.Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Encode
{
    class CaesarEncoder : Encoder
    {
        public CaesarEncoder(string text, string key) : base(text, key) { }

        public override EncodedMessage Create()
        {
            ICipher caesar = new CaesarCipher();
            string encoded = caesar.Encrypt(text, key);
            return new CaesarEncodedMessage(encoded);
        }
    }
}
