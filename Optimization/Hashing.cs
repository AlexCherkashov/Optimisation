using System.Text;
using System.Security.Cryptography;

namespace Optimization
{
    public class Hashing
    {
        public static string GetHash(string password)
        {
            SHA256 mySHA256 = SHA256.Create();
            byte[] byteHash = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(password));

            var sb = new StringBuilder();
            foreach (byte value in byteHash)
            {
                sb.Append(value.ToString("x2"));
            }

            return sb.ToString();
        }

        public static bool VerifyHash(string input, string hash)
        {
            return GetHash(input).Equals(hash);
        }
    }
}
