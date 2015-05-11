using EF_Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Rivers_by_Country
{
    class FindRiversByCountry
    {
        static void Main()
        {
            var context = new GeographyEntities();
            var xmlDoc = XDocument.Load(@"..\..\rivers-query.xml");
            
            foreach (var queryElement in xmlDoc.XPathSelectElements("/queries/query"))
            {
                IQueryable<River> riversQuery = context.Rivers.AsQueryable();
                foreach (var countryElement in queryElement.XPathSelectElements("country"))
                {
                    var countryName = countryElement.Value;
                    riversQuery = riversQuery.Where(
                                                    r => r.Countries.Any(c => c.CountryName == countryName)
                                                );
                }
                riversQuery = riversQuery.OrderBy(r => r.RiverName);
                var maxResultsAttribute =  queryElement.Attribute("max-results");
                if (maxResultsAttribute != null)
                {
                    int maxResults = int.Parse(maxResultsAttribute.Value);
                    riversQuery = riversQuery.Take(maxResults);
                }
                var riverNames = riversQuery.Select(r => r.RiverName);
                Console.WriteLine(string.Join(", ", riverNames));
                Console.WriteLine();
            }
        }
    }
}
