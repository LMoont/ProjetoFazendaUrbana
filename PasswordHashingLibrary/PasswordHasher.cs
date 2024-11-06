using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHashingLibrary
{
    public class PasswordHasher
    {
        public static string HashSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computa o hash da senha
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                // Converte o hash para uma string hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
