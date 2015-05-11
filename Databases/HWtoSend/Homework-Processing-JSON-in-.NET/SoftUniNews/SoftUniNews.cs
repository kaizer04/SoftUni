namespace SoftUniNews
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SoftUniNews
    {
        public static void Main()
        {
            // Task1
            var xmlPath = @"../../rss.xml";
            GetRssFeed(xmlPath);

            // Task2
            var xml = XDocument.Load(xmlPath);
            var json = JsonConvert.SerializeXNode(xml);

            // Task3
            var allTitles = GetAllTitles(json);

            Console.WriteLine(string.Join(Environment.NewLine, allTitles));

            // Task4
            var pocoObjects = GetPocoObjects(json);

            // Task5
            var htmlString = BuildHtmlString(pocoObjects);

            var htmlPath = @"../../index.html";

            using (var writer = new StreamWriter(htmlPath))
            {
                writer.Write(htmlString);
            }
        }

        private static string BuildHtmlString(IEnumerable<News> pocoObjects)
        {
            var sb = new StringBuilder();
            sb.Append("<!DOCTYPE html><html><head></head><body><h1>Software University News Feed</h1><ul>");

            foreach (var obj in pocoObjects)
            {
                sb.Append("<li><a href=\"");
                sb.Append(obj.Link);
                sb.Append("\">");
                sb.Append(obj.Title);
                sb.Append("</a>[");
                sb.Append(obj.Description);
                sb.Append("]</li>");
            }

            sb.Append("</ul></body></html>");

            Console.WriteLine("HTML Created successfully");
            return sb.ToString();
        }

        private static IEnumerable<News> GetPocoObjects(string json)
        {
            var jObject = JObject.Parse(json);

            var newsList = jObject["rss"]["channel"]["item"]
                .Select(i => JsonConvert.DeserializeObject<News>(i.ToString()));

            return newsList;
        }

        private static IEnumerable<object> GetAllTitles(string json)
        {
            var jObject = JObject.Parse(json);

            return jObject["rss"]["channel"]["item"].Select(i => i["title"]);
        }

        private static void GetRssFeed(string filePath)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://softuni.bg/Feed/News", filePath);
            }
        }
    }
}
