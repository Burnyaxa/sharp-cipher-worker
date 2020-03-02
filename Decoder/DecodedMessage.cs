using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Decoder
{
    abstract class DecodedMessage
    {
        string text { get; }
        public DecodedMessage(string text)
        {
            this.text = text;
        }
    }
}
