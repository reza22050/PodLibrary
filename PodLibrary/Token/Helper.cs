using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodLibrary.Token
{
    public static class Helper
    {
        public static string GetTimeStamp(string apiDateTime)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.Parse(apiDateTime);
            long unixTimestamp = dateTimeOffset.ToUnixTimeSeconds();

            // Convert the Unix timestamp to a string
            string apiDateTimeUnix = unixTimestamp.ToString();
            return apiDateTimeUnix;
        }


    }
}
