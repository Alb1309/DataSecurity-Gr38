using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography; // Permban support-in per shumicen  e algoritmeve kriptografike si
using System.Text; // Permban klasa te cilat reprezentojne enkodime te karaktereve me ASCII dhe UNICODE
using System.Threading.Tasks;

namespace ProductionProject //Program.cs
{
    public class Cryptog //KriptKlasa
    {
        private byte[] key = new byte[8] { 3, 1, 4, 5, 6, 2, 4, 9 };
        private byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }; 

        public string Crypt(string text, string key_) //KriptFunksioni
        {
            iv = Encoding.ASCII.GetBytes(key_);
            SymmetricAlgorithm algorithm = DES.Create();    //algorithm = AlgKrijo
            ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);    //transform = encAlgKrijo
            byte[] inputbuffer = Encoding.Unicode.GetBytes(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Convert.ToBase64String(outputBuffer);
        }

        public string Decrypt(string text, string iv_)
        {
            iv = Encoding.ASCII.GetBytes(iv_);
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
            byte[] inputbuffer = Convert.FromBase64String(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Encoding.Unicode.GetString(outputBuffer);
        }
    }
}