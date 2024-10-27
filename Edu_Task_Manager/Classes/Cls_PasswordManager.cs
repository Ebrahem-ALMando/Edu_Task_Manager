using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Edu_Task_Manager.Classes.Login
{
    internal class Cls_PasswordManager
    {
        public static (string hashedPassword, string salt) HashPassword(string password)
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            string salt = Convert.ToBase64String(saltBytes);


            using (SHA256 sha256Hash = SHA256.Create())
            {
                string passwordWithSalt = password + salt;
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSalt));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return (builder.ToString(), salt); 
            }
        }
        public static bool VerifyPassword(string password, string storedHashedPassword, string storedSalt)
        {
        
            string passwordWithSalt = password + storedSalt;

      
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSalt));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                string hashedInputPassword = builder.ToString();

                return hashedInputPassword.Equals(storedHashedPassword);
            }
        }
    }
}
