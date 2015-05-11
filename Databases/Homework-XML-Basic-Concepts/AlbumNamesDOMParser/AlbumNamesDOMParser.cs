namespace AlbumNamesDOMParser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class AlbumNamesDOMParser
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var albumNode = node["name"];
                if (albumNode != null)
                {
                    Console.WriteLine(albumNode.InnerText);
                }
            }
        }
    }
}
