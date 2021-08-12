using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace CSHARP.Multithreading
{
    public class Async
    {
        public async Task execute()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            await RunDownloadAsync();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

           System.Console.WriteLine($"Total execution time: { elapsedMs }");
        }
        private async Task RunDownloadAsync()
        {
            List<string> websites = PrepData();

            foreach (string site in websites)
            {
                WebsiteDataModel results = await Task.Run(() => DownloadWebsite(site));
                ReportWebsiteInfo(results);
            }
        }
        private WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL);

            return output;
        }
        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
           System.Console.WriteLine($"{ data.WebsiteUrl } downloaded: { data.WebsiteData.Length } characters long.{ Environment.NewLine }");
        }
        private List<string> PrepData()
        {
            List<string> output = new List<string>();

            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }
    }
}