using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace ApplicationLayer
{
    public static class PasswordHelper
    {
            public static string HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    StringBuilder result = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        result.Append(b.ToString("x2"));
                    }
                    return result.ToString();
                }
            }

            public static bool VerifyPassword(string inputPassword, string storedHash)
            {
                return HashPassword(inputPassword) == storedHash;
            }
        }
}
