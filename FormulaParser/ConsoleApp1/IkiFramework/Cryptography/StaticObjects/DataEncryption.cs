using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace IkiCore.Cryptography
{
    public static class DataEncryption
    {
        public static string SimpleEncrypt(string input, string key)
        {
            List<int> encryptedLetters = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                encryptedLetters.Add(input[i]);
            }
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < encryptedLetters.Count; j++)
                {
                    encryptedLetters[j] = Cyphers.Cypher16((short)(key[i] ^ encryptedLetters[j]), key[key.Length - 1 - i]);
                }
                Cyphers.BitsPermute(encryptedLetters, 1);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encryptedLetters.Count; i++)
            {
                sb.Append((char)encryptedLetters[i]);
            }
            return sb.ToString();
        }
        public static string SimpleDecrypt(string input, string key)
        {
            List<int> encryptedLetters = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                encryptedLetters.Add(input[i]);
            }
            for (int i = key.Length - 1; i > -1; i--)
            {
                Cyphers.BitsPermute(encryptedLetters, 1);
                for (int j = 0; j < encryptedLetters.Count; j++)
                {
                    encryptedLetters[j] = key[i] ^ Cyphers.Cypher16((short)encryptedLetters[j], key[key.Length - 1 - i], true);
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encryptedLetters.Count; i++)
            {
                sb.Append((char)encryptedLetters[i]);
            }
            return sb.ToString();
        }
        public static string Encrypt(string text, string encryptionKey = "")
        {
            string EncryptionKey = (encryptionKey == "") ? Constant.DefaultKey : encryptionKey;
            byte[] clearBytes = Encoding.Unicode.GetBytes(text);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    text = Convert.ToBase64String(ms.ToArray());
                }
            }
            return text;
        }
        public static string Decrypt(string cryptedText, string encryptionKey = "")
        {
            string EncryptionKey = (encryptionKey == "") ? Constant.DefaultKey : encryptionKey;
            cryptedText = cryptedText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cryptedText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cryptedText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cryptedText;
        }
        public static string SHA256_SafeEncrypt(string data)
        {
            return Encoding.ASCII.GetString(new SHA256Managed().ComputeHash(Encoding.ASCII.GetBytes(data)));
        }
        public static string SHA512_SafeEncrypt(string data)
        {
            return Encoding.ASCII.GetString(new SHA512Managed().ComputeHash(Encoding.ASCII.GetBytes(data)));
        }
        public static bool SHA256_SafeCompare(string data, string hash)
        {
            return Encoding.ASCII.GetString(new SHA256Managed().ComputeHash(Encoding.ASCII.GetBytes(data))) == hash;
        }
        public static bool SHA512_SafeCompare(string data, string hash)
        {
            return Encoding.ASCII.GetString(new SHA512Managed().ComputeHash(Encoding.ASCII.GetBytes(data))) == hash;
        }
        public static string GenerateAPassKey(string textToKey)
        {
            return Convert.ToBase64String(new PasswordDeriveBytes(textToKey, Encoding.ASCII.GetBytes(textToKey), "SHA1", 2).GetBytes(256 / 11));
        }
    }
}
