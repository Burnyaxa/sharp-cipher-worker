using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Decode
{
    abstract class DecodedMessage
    {
        public string text { get; private set; }
        public DecodedMessage(string text)
        {
            this.text = text;
        }
    }
}
