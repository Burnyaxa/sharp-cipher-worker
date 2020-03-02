using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Decoder
{
   abstract class Decoder
    {
        protected string text;
        protected string key;
        public Decoder(string text, string key)
        {
            this.text = text;
            this.key = key;
        }
        public abstract DecodedMessage Create(string text, string key);
    }
}
