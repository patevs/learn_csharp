/**
 *  1_requests/Requests.cs
 */

using System;
using System.IO;
using System.Net;
// using System.Net.Http;
// using System.Threading.Tasks; // .Task;

namespace Requests
{
    class Program
    {
      /*
      public async Task<string> GetAsync(string uri)
      {
          HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
          request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

          using(HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
          using(Stream stream = response.GetResponseStream())
          using(StreamReader reader = new StreamReader(stream))
          {
            Task<string> result = await reader.ReadToEndAsync();
            Console.WriteLine(result);
            return result;
            // return await reader.ReadToEndAsync();
          }
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
        // GetAsync(url);
      }
    }
}

/* EOF */
