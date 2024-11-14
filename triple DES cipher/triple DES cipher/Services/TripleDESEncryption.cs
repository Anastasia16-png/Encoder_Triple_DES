using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace triple_DES_cipher.Services
{
    public class TripleDESEncryption
    {
        private readonly TripleDESCryptoServiceProvider _tripleDes;

        public TripleDESEncryption(string key)
        {
            _tripleDes = new TripleDESCryptoServiceProvider
            {
                Key = Encoding.UTF8.GetBytes(key.PadRight(24, ' ')), // ключ довжиною 24 байти
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
        }

        public string Encrypt(string plaintext)
        {
            byte[] data = Encoding.UTF8.GetBytes(plaintext);
            ICryptoTransform transform = _tripleDes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(result);
        }

        public string Decrypt(string ciphertext)
        {
            byte[] data = Convert.FromBase64String(ciphertext);
            ICryptoTransform transform = _tripleDes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return Encoding.UTF8.GetString(result);
        }
    }
}
