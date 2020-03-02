using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Encoder
{
    abstract class EncodedMessage
    {
        string text { get; }
        public EncodedMessage(string text)
        {
            this.text = text;
        }
    }
}
