using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher.Cipher
{
    interface IChiper
    {
        public string Encrypt(string text, string key);
        public string Decrypt(string text, string key);
    }
}
