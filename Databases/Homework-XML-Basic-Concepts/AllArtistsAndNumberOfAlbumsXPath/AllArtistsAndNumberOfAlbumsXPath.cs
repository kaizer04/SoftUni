namespace AllArtistsAndNumberOfAlbumsXPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class AllArtistsAndNumberOfAlbumsXPath
    {
        public static void Main()
        {
            Dictionary<string, int> numberOfSongs = new Dictionary<string, int>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalog.xml");
            string xPathQuery = "/albums/album";

            XmlNodeList albumsList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode albumNode in albumsList)
            {
                string albumArtist = albumNode.SelectSingleNode("artist").InnerText;
                if (!numberOfSongs.ContainsKey(albumArtist))
                {
                    numberOfSongs.Add(albumArtist, 0);
                }

                foreach (XmlNode song in albumNode.SelectSingleNode("songs"))
                {
                    numberOfSongs[albumArtist]++;
                }
            }

            foreach (var artist in numberOfSongs)
            {
                Console.WriteLine("{0} -> {1} songs", artist.Key, artist.Value);
            }
        }
    }
}
