using System;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp2.Helpers
{
    public static class PasswordHasher
    {
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] combined = Encoding.UTF8.GetBytes(password + salt);
                byte[] hash = sha256.ComputeHash(combined);
                return Convert.ToBase64String(hash);
            }
        }

        public static bool Verify(string password, string salt, string expectedHash)
        {
            return HashPassword(password, salt) == expectedHash;
        }
    }
}