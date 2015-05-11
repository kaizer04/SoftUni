namespace AllArtistDomParser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class AllArtistDomParser
    {
        public static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            var artistSorted = new SortedSet<string>();
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artistNode = node["artist"];
                
                artistSorted.Add(artistNode.InnerText);
            }

            foreach (var artist in artistSorted)
            {
                Console.WriteLine(artist);
            }
        }
    }
}
