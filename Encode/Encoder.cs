using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Encode
{
    abstract class Encoder
    {
        public string text { get; private set; }
        public string key { get; private set; }
        public Encoder(string text, string key)
        {
            this.text = text;
            this.key = key;
        }
        public abstract EncodedMessage Create();
    }
}

