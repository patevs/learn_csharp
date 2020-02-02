/**
 *  1_examples/Examples.cs
 */

using System;

namespace Examples
{
    class Program
    {
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
      static void Main(string[] args)
      {
        // Console.WriteLine("Hello World!");
        // Display the number of command line arguments.
        // Console.WriteLine(args.Length);
        Get();
      }
    }
}

/* EOF */
