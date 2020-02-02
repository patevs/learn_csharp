/**
 *  1_requests/Requests.cs
 */

using System;
using System.IO;
using System.Net;
// using System.Net.Http;

namespace Requests
{
    class Program
    {
      /*
      public void Get() {
        Console.WriteLine("Making GET Request...");
        string html = string.Empty;
        string url = @"https://api.stackexchange.com/2.2/answers?order=desc&sort=activity&site=stackoverflow";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.AutomaticDecompression = DecompressionMethods.GZip;

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            html = reader.ReadToEnd();
        }

        Console.WriteLine(html);
      }
      */

      public static string Get(string uri)
      {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using(Stream stream = response.GetResponseStream())
        using(StreamReader reader = new StreamReader(stream))
        {
          string result = reader.ReadToEnd();
          Console.WriteLine(result);
          return result;
        }
      }

      static void Main(string[] args)
      {
        Console.WriteLine("\n --- EXAMPLES --- \n");
        // Display the number of command line arguments.
        // Console.WriteLine(args.Length);
        // Get();
        string url = @"https://api.stackexchange.com/2.2/answers?order=desc&sort=activity&site=stackoverflow";
        Get(url);
      }
    }
}

/* EOF */
