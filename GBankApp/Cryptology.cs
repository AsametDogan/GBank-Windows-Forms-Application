using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBankApp
{
    class Cryptology
    {
        static int key = 5;
        public static string Encrypt(string password)
        {//Encrypt the input parameter
            char[] section = password.ToCharArray();
            string encryptedPassword = "";
            foreach (char letter in section)
            {
                encryptedPassword += Convert.ToChar(letter+key);
            }
            return encryptedPassword;

        }
        public static string Decrypt (string password)
        {//Decrypt the input parameter
            char[] fraction = password.ToCharArray();
            string decryptedPassword = "";
            foreach (char letter in fraction)
            {
                decryptedPassword += Convert.ToChar(letter - key);
            }
            return decryptedPassword;

        }

    }
}
