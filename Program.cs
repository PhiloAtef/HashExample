using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Dynamic;

namespace HashingExample
{
    class Program
    {
        //hashing method
        static string HashSha256(string Data)
        {
            //create a SHA256 object 
            SHA256 sHA256hash = SHA256.Create();
            //gets the byte array of DATA, hashes it then adds it to the bytes array
            byte[] bytes = sHA256hash.ComputeHash(Encoding.UTF8.GetBytes(Data));
            //creating a string builder to format the resulting hash into a string
            StringBuilder strbuilder = new StringBuilder();
            // for loop to append the bytes array into a string with a hexadecimal format 
            for (int i = 0; i < bytes.Length; i++)
            {
                strbuilder.Append(bytes[i].ToString("x2"));
            }
            // returns the resulting string hash
            return strbuilder.ToString();
        }
        static void Main(string[] args)
        {
            string originalData = "ABCDE";
            Console.WriteLine("original data ="+ originalData);
            string hashedData = HashSha256(originalData);
            Console.WriteLine("hashed data ="+ hashedData);
            Console.ReadLine();
        }
    }
}
