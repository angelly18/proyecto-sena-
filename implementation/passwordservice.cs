using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Threading.Tasks;
using mi_proyecto_sena.services;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace mi_proyecto_sena.implementation
{
    public class passwordservice : IPasswoedservice
    {
        public string Hashpassword(string password)
        {
            string hashedPassword;
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000 ,
                numBytesRequested: 256 / 8));
                return hashedPassword;
            


        }
    }
}
