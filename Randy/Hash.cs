using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Randy
{
    public class Hash
    {
        public static string SHA1(byte[] input)
        {
            var sBuilder = new StringBuilder();
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(input);


                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sBuilder.Append(b.ToString("X2"));
                }
            }

            return sBuilder.ToString();
        }
        //****************************//
        public static string MD5(byte[] input)
        {
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            using (MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(input);

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("X2"));
                }
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        //****************************//
        public static string SHA256(byte[] input)
        {
            var sBuilder = new StringBuilder();
            using (SHA256Managed sha1 = new SHA256Managed())
            {
                var hash = sha1.ComputeHash(input);


                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sBuilder.Append(b.ToString("X2"));
                }
            }

            return sBuilder.ToString();
        }
        //****************************//
        public static string SHA384(byte[] input)
        {
            var sBuilder = new StringBuilder();
            using (SHA384Managed sha1 = new SHA384Managed())
            {
                var hash = sha1.ComputeHash(input);


                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sBuilder.Append(b.ToString("X2"));
                }
            }

            return sBuilder.ToString();
        }
        //****************************//
        public static string SHA512(byte[] input)
        {
            var sBuilder = new StringBuilder();
            using (SHA512Managed sha1 = new SHA512Managed())
            {
                var hash = sha1.ComputeHash(input);


                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sBuilder.Append(b.ToString("X2"));
                }
            }

            return sBuilder.ToString();
        }
        //****************************//

    }
}
