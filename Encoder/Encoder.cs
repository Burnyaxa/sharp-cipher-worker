using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Encoder
{
    abstract class Encoder
    {
        protected string text;
        protected string key;
        public Encoder(string text, string key)
        {
            this.text = text;
            this.key = key;
        }
        public abstract EncodedMessage Create(string text, string key);
    }
}

