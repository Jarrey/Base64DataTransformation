using System;
using System.Text;
using System.Security.Cryptography;

namespace DataTransformation
{
  internal class EncryptionTool
  {
    internal static string Encrypt(string key, byte[] data)
    {
      byte[] tdesKey = HashKey(key);
      using (var tdesAlgorithm = new AesCryptoServiceProvider
      {
        Key = tdesKey,
        Mode = CipherMode.ECB
      })
      {
        var encryptor = tdesAlgorithm.CreateEncryptor();
        var results = encryptor.TransformFinalBlock(data, 0, data.Length);
        return Convert.ToBase64String(results);
      }
    }

    internal static byte[] Decrypt(string key, string data)
    {
      byte[] tdesKey = HashKey(key);
      using (var tdesAlgorithm = new AesCryptoServiceProvider
      {
        Key = tdesKey,
        Mode = CipherMode.ECB
      })
      {
        byte[] dataToDecrypt = Convert.FromBase64String(data);
        var decryptor = tdesAlgorithm.CreateDecryptor();
        return decryptor.TransformFinalBlock(dataToDecrypt, 0, dataToDecrypt.Length);
      }
    }

    private static byte[] HashKey(string key)
    {
      var hashProvider = new MD5CryptoServiceProvider();
      try
      {
        return hashProvider.ComputeHash(Encoding.UTF8.GetBytes(key));
      }
      finally
      {
        hashProvider.Clear();
      }
    }
  }
}
