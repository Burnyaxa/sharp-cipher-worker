using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Encode
{
    abstract class EncodedMessage
    {
        public string text { get; private set; }
        public EncodedMessage(string text)
        {
            this.text = text;
        }
    }
}
