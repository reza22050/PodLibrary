using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test.Token
{
    public static class ApiKeyGenerator
    {
        public static string Generate_XApiKey(string key, long apiDateTime, string secretKey)
        {
            // Convert secretKey and apiDateTime to byte arrays
            byte[] secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            byte[] apiDateTimeBytes = Encoding.UTF8.GetBytes(apiDateTime.ToString());

            // Compute HMACSHA256 hash
            using (var hmac = new HMACSHA256(secretKeyBytes))
            {
                byte[] hashBytes = hmac.ComputeHash(apiDateTimeBytes);

                // Convert hash to base64
                string base64Hash = Convert.ToBase64String(hashBytes);

                // Construct the final API key
                string apiKey = $"{key}:{base64Hash}";

                return apiKey;
            }
        }

    }
}
