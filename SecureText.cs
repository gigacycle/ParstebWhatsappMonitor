using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ParstebWhatsapp
{
    public class SecureText
    {
        static string _key = "ay$a5%&jwrtTebNegar3Dmnh;lasjdf98787";
        static string _iv = "abc@98797hjkas$&asd(*$%";
        static byte[] _ivByte = { };

        public static string Encrypt(string textToEncrypt)
        {
            try
            {
                string ToReturn = "";


                _ivByte = Encoding.UTF8.GetBytes(_iv.Substring(0, 8));
                byte[] _keybyte = { };
                _keybyte = Encoding.UTF8.GetBytes(_key.Substring(0, 8));
                MemoryStream ms = null; CryptoStream cs = null;
                byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(_keybyte, _ivByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, ae.Message);
                return "";
            }
        }
        public static string Decrypt(string textToDecrypt)
        {
            try
            {
                string ToReturn = "";
                _ivByte = Encoding.UTF8.GetBytes(_iv.Substring(0, 8));
                byte[] _keybyte = { };
                _keybyte = Encoding.UTF8.GetBytes(_key.Substring(0, 8));
                MemoryStream ms = null; CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(_keybyte, _ivByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, ae.Message);
                return "";
            }
        }
    }
}
