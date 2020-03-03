using lab1cipher.Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Decode
{
    class CaesarDecoder : Decoder
    {
        public CaesarDecoder(string text, string key) : base(text, key) { }

        public override DecodedMessage Create()
        {
            ICipher caesar = new CaesarCipher();
            string decoded = caesar.Decrypt(text, key);
            return new CaesarDecodedMessage(decoded);
        }
    }
}
