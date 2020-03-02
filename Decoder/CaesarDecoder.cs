using lab1cipher.Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Decoder
{
    class CaesarDecoder : Decoder
    {
        public CaesarDecoder(string text, string key) : base(text, key) { }

        public override DecodedMessage Create(string text, string key)
        {
            ICipher caesar = new CaesarCipher();
            string decoded = caesar.Decrypt(text, key);
            return new CaesarDecodedMessage(decoded);
        }
    }
}
