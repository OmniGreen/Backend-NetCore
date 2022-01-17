using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Uzx.Infra.Commons.Authentication
{
    public  sealed class CodeFirstCrypto
    {

        private const int TOKEN_SIZE_IN_BYTES = 16;
        private const int PBKDF2_ITER_COUNT = 1000;
        // default for Rfc2898DeriveBytes
        private const int PBKDF2_SUBKEY_LENGTH = 256 / 8;
        // 256 bits
        private const int SALT_SIZE = 128 / 8;
        // 128 bits
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "byte", Justification = "It really Is a byte length")]
        internal static byte[] GenerateSaltInternal(int byteLength = SALT_SIZE)
        {
            byte[] buf = new byte[byteLength];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(buf);
            }
            return buf;
        }

        static internal string GenerateToken()
        {
            byte[] tokenBytes = new byte[TOKEN_SIZE_IN_BYTES];
            using (RNGCryptoServiceProvider prng = new RNGCryptoServiceProvider())
            {
                prng.GetBytes(tokenBytes);
                return Convert.ToBase64String(tokenBytes);
            }
        }

        public  static string GenerateSalt(int byteLength = SALT_SIZE)
        {
            return Convert.ToBase64String(GenerateSaltInternal(byteLength));
        }

        public  static string Hash(string input, string algorithm = "sha256")
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            return Hash(Encoding.UTF8.GetBytes(input), algorithm);
        }

        public  static string Hash(byte[] input, string algorithm = "sha256")
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            using (HashAlgorithm alg = HashAlgorithm.Create(algorithm))
            {
                if (alg != null)
                {
                    byte[] hashData = alg.ComputeHash(input);
                    return BinaryToHex(hashData);
                }
                else
                {
                    throw new InvalidOperationException(String.Format(string.Format("Not supported hash algorhitm {0}", algorithm)));
                }
            }
        }

        public  static string SHA1(string input)
        {
            return Hash(input, "sha1");
        }

        public  static string SHA256(string input)
        {
            return Hash(input, "sha256");
        }

        // =======================
        //         * HASHED PASSWORD FORMATS
        //         * =======================
        //         * 
        //         * Version 0:
        //         * PBKDF2 with HMAC-SHA1, 128-bit salt, 256-bit subkey, 1000 iterations.
        //         * (See also: SDL crypto guidelines v5.1, Part III)
        //         * Format: { 0x00, salt, subkey }
        //         


        public  static string HashPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }

            // Produce a version 0 (see comment above) password hash.
            byte[] salt;
            byte[] subkey;
            using (var deriveBytes = new Rfc2898DeriveBytes(password, SALT_SIZE, PBKDF2_ITER_COUNT))
            {
                salt = deriveBytes.Salt;
                subkey = deriveBytes.GetBytes(PBKDF2_SUBKEY_LENGTH);
            }

            byte[] outputBytes = new byte[1 + SALT_SIZE + PBKDF2_SUBKEY_LENGTH];
            Buffer.BlockCopy(salt, 0, outputBytes, 1, SALT_SIZE);
            Buffer.BlockCopy(subkey, 0, outputBytes, 1 + SALT_SIZE, PBKDF2_SUBKEY_LENGTH);
            return Convert.ToBase64String(outputBytes);
        }
        
        // hashedPassword must be of the format of HashWithPassword (salt + Hash(salt+input)
        public  static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            if (hashedPassword == null)
            {
                throw new ArgumentNullException("hashedPassword");
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }

            byte[] hashedPasswordBytes = Convert.FromBase64String(hashedPassword);

            // Verify a version 0 (see comment above) password hash.

            if (hashedPasswordBytes.Length != (1 + SALT_SIZE + PBKDF2_SUBKEY_LENGTH) || hashedPasswordBytes[0] != (byte)0x00)
            {
                // Wrong length or version header.
                return false;
            }

            byte[] salt = new byte[SALT_SIZE];
            Buffer.BlockCopy(hashedPasswordBytes, 1, salt, 0, SALT_SIZE);
            byte[] storedSubkey = new byte[PBKDF2_SUBKEY_LENGTH];
            Buffer.BlockCopy(hashedPasswordBytes, 1 + SALT_SIZE, storedSubkey, 0, PBKDF2_SUBKEY_LENGTH);

            byte[] generatedSubkey;
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, PBKDF2_ITER_COUNT))
            {
                generatedSubkey = deriveBytes.GetBytes(PBKDF2_SUBKEY_LENGTH);
            }
            return ByteArraysEqual(storedSubkey, generatedSubkey);
        }

        internal static string BinaryToHex(byte[] data)
        {
            char[] hex = new char[data.Length * 2];

            for (int iter = 0; iter < data.Length; iter++)
            {
                byte hexChar = ((byte)(data[iter] >> 4));
                hex[iter * 2] = (char)(hexChar > 9 ? hexChar + 0x37 : hexChar + 0x30);
                hexChar = ((byte)(data[iter] & 0xF));
                hex[iter * 2 + 1] = (char)(hexChar > 9 ? hexChar + 0x37 : hexChar + 0x30);
            }
            return new string(hex);
        }

        // Compares two byte arrays for equality. The method Is specifically written so that the loop Is not optimized.
        [MethodImpl(MethodImplOptions.NoOptimization)]
        private static bool ByteArraysEqual(byte[] a, byte[] b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (a == null || b == null || a.Length != b.Length)
            {
                return false;
            }

            bool areSame = true;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                areSame = areSame & (a[i] == b[i]);
            }
            return areSame;
        }

        // Hash an input string and return the hash as
        // a 32 character hexadecimal string.
        private static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public  static bool verifyMd5Hash(string hashedPassword, string password)
        {
            // Hash the input.
            string hashOfInput = getMd5Hash(password);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hashedPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public static string DecryptStringAES(string cipherText)
        {
            var keybytes = Encoding.UTF8.GetBytes("4512631236589784");
            var iv = Encoding.UTF8.GetBytes("4512631236589784");

            var encrypted = Convert.FromBase64String(cipherText);
            var decriptedFromJavascript = DecryptStringFromBytes(encrypted, keybytes, iv);
            return decriptedFromJavascript;
        }

        private static string DecryptStringFromBytes(byte[] cipherText, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }
            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }
            if (iv == null || iv.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an RijndaelManaged object
            // with the specified key and IV.
            using (var rijAlg = new RijndaelManaged())
            {
                //Settings
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.FeedbackSize = 128;

                rijAlg.Key = key;
                rijAlg.IV = iv;

                // Create a decrytor to perform the stream transform.
                var decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                try
                {
                    // Create the streams used for decryption.
                    using (var msDecrypt = new MemoryStream(cipherText))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {

                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                // Read the decrypted bytes from the decrypting stream
                                // and place them in a string.
                                plaintext = srDecrypt.ReadToEnd();

                            }

                        }
                    }
                }
                catch
                {
                    plaintext = "keyError";
                }
            }

            return plaintext;
        }

        public static string EncryptStringAES(string plainText)
        {
            var keybytes = Encoding.UTF8.GetBytes("4512631236589784");
            var iv = Encoding.UTF8.GetBytes("4512631236589784");

            var encryoFromJavascript = EncryptStringToBytes(plainText, keybytes, iv);
            return Convert.ToBase64String(encryoFromJavascript);
        }

        private static byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }
            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }
            if (iv == null || iv.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }
            byte[] encrypted;
            // Create a RijndaelManaged object
            // with the specified key and IV.
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.FeedbackSize = 128;

                rijAlg.Key = key;
                rijAlg.IV = iv;

                // Create a decrytor to perform the stream transform.
                var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

    }
}