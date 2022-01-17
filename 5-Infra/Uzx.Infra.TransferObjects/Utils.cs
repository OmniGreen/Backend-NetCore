using System;
using System.Text;
using System.Security.Cryptography;

namespace Uzx.Infra.TransferObjects
{
    public  class Utils
    {
        /// <summary>
        /// Recebe a data (Epoch), devolve o datetime
        /// </summary>
        /// <param name="unixTimeMilliseconds"></param>
        /// <returns></returns>
        public  static DateTime FromEpochToUtc(long unixTimeMilliseconds)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(unixTimeMilliseconds);
        }

        public  static long FromUtcToEpoch(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - epoch).TotalSeconds);
        }

        public  static byte[] HashSHA1(string input)
        {
            // Transforma String em Bytes
            byte[] data = Encoding.Default.GetBytes(input);

            // Instancia de Hash SHA1
            SHA1 sha = new SHA1CryptoServiceProvider();
            // ThIs Is one implementation of the abstract class SHA1.
            return sha.ComputeHash(data);
        }
    }
}
