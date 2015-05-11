﻿namespace OldItemsXPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class OldItemsXPath
    {
        public static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalog.xml");

            // album 3 is 2012
            string xPathQuery = "/albums/album[year<2010]";

            XmlNodeList oldAlbums = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode album in oldAlbums)
            {
                Console.WriteLine(album.SelectSingleNode("name").InnerText + " -> " + album.SelectSingleNode("price").InnerText);
            }
        }
    }
}
