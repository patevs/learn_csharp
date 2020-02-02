/**
 *  1_examples/Examples.cs
 */

using System;
// using System.Net;
// using System.Net.Http;

namespace Examples
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

      public string Get(string uri)
      {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using(Stream stream = response.GetResponseStream())
        using(StreamReader reader = new StreamReader(stream))
        {
          return reader.ReadToEnd();
        }
      }
      */

      static void Main(string[] args)
      {
        Console.WriteLine("\n --- EXAMPLES --- \n");
        // Display the number of command line arguments.
        // Console.WriteLine(args.Length);
        // Get();
        // string url = @"https://api.stackexchange.com/2.2/answers?order=desc&sort=activity&site=stackoverflow";
        // Get(url);
      }
    }
}

/* EOF */
