using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashVerifier
{
    public class HashEngine
    {

        public HashEngine()
        {

        }

        public byte[] HashFileMD5(string filePath)
        {
            var md5Millis = System.Environment.TickCount;

            byte[] md5HashBytes;
            MD5CryptoServiceProvider hasher = new MD5CryptoServiceProvider();
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                md5HashBytes = hasher.ComputeHash(stream);
            }

            Debug.WriteLine("md5 millis: " + (System.Environment.TickCount - md5Millis));

            return md5HashBytes;
        }

        public byte[] HashFileSHA1(string filePath)
        {
            var sha1Millis = System.Environment.TickCount;
            byte[] sha1HashBytes;

            SHA1CryptoServiceProvider hasher = new SHA1CryptoServiceProvider();

            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                sha1HashBytes = hasher.ComputeHash(stream);
            }

            Debug.WriteLine("SHA1 millis: " + (System.Environment.TickCount - sha1Millis));

            return sha1HashBytes;
        }

        public byte[] HashFileSHA256(string filePath)
        {
            var sha256Millis = System.Environment.TickCount;
            byte[] sha256HashBytes;

            SHA256CryptoServiceProvider hasher = new SHA256CryptoServiceProvider();

            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                sha256HashBytes = hasher.ComputeHash(stream);
            }

            Debug.WriteLine("SHA256 millis: " + (System.Environment.TickCount - sha256Millis));

            return sha256HashBytes;
        }

        public String ConvertToHexString(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}
