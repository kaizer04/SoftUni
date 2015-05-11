using EF_Mappings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Export_Monasteries_as_XML
{
    public class ExportMonasteriesAsXml
    {
        public static void Main()
        {
            var context = new GeographyEntities();
            var countriesQuery = context.Countries
                                    .Where(c => c.Monasteries.Any())
                                    .OrderBy(c => c.CountryName)
                                    .Select(c => new
                                    {
                                        CountryName = c.CountryName,
                                        Monasteries = c.Monasteries
                                                     .OrderBy(m => m.Name)
                                                    .Select(m => m.Name)
                                    });

            var xmlDoc = new XDocument();
            var xmlRoot = new XElement("monasteries");
            xmlDoc.Add(xmlRoot);

            foreach (var country in countriesQuery)
            {
                //if (country.Monasteries.Any())
                //{
                    // the code down should be here 
                //}
                var countryXml = new XElement("country", new XAttribute("name", country.CountryName));
                xmlRoot.Add(countryXml);
                foreach (var monastery in country.Monasteries)
                {
                    var monasteryXml = new XElement("monastery", monastery);
                    countryXml.Add(monasteryXml);
                }
            }

            //Console.WriteLine(xmlDoc);

            xmlDoc.Save("monasteries.xml");
        }
    }
}
