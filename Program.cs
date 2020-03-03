using lab1cipher.Cipher;
using lab1cipher.Encode;
using lab1cipher.Decode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1cipher
{
    class Program
    {
        public enum Task
        {
            Exit,
            Encrypt,
            Decrypt
        }
        public enum Cipher
        {
            Vigenere,
            Caesar
        }
        static void Main(string[] args)
        {
            string text, key;
            while (true)
            {
                Console.WriteLine("What to do?");
                Console.WriteLine("1. Encrypt");
                Console.WriteLine("2. Decrypt");
                Console.WriteLine("0. Exit");
                Task task = (Task)Convert.ToInt32(Console.ReadLine());
                if (task == Task.Exit) break;
                Console.WriteLine("Which cipher?");
                Console.WriteLine("1. Vigenere");
                Console.WriteLine("2. Caesar");
                Cipher cipher = (Cipher)Convert.ToInt32(Console.ReadLine()) - 1;
                switch (task)
                {
                    case Task.Encrypt:
                        text = GetText();
                        key = GetKey();
                        switch (cipher)
                        {
                            case Cipher.Vigenere:
                                Encode.Encoder encVig = new VigenereEncoder(text, key);
                                EncodedMessage msgVig = encVig.Create();
                                Console.WriteLine("Encrypted message: {0}", msgVig.text);
                                break;
                            case Cipher.Caesar:
                                Encode.Encoder encCaesar = new CaesarEncoder(text, key);
                                EncodedMessage msgCaesar = encCaesar.Create();
                                Console.WriteLine("Encrypted message: {0}", msgCaesar.text);
                                break;
                        }
                        break;
                    case Task.Decrypt:
                        text = GetText();
                        key = GetKey();
                        switch (cipher)
                        {
                            case Cipher.Vigenere:
                                Decode.Decoder decVig = new VigenereDecoder(text, key);
                                DecodedMessage msgVig = decVig.Create();
                                Console.WriteLine("Decrypted message: {0}", msgVig.text);
                                break;
                            case Cipher.Caesar:
                                Decode.Decoder decCaesar = new CaesarDecoder(text, key);
                                DecodedMessage msgCaesar = decCaesar.Create();
                                Console.WriteLine("Decrypted message: {0}", msgCaesar.text);
                                break;
                        }
                        break;
                }
            }
            Console.ReadKey();
        }

        public static string GetText()
        {
            string text;
            Console.Write("Enter the text: ");
            text = Console.ReadLine();
            return text;
        }

        public static string GetKey()
        {
            string key;
            Console.Write("Enter the key: ");
            key = Console.ReadLine();
            return key;
        }
    }
}
