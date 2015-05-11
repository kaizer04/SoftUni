namespace Export_Rivers_as_JSON
{
    using EF_Mappings;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Script.Serialization;

    public class ExportRiversAsJson
    {
        public static void Main()
        {
            var context = new GeographyEntities();
            var riversQuery = context.Rivers
                                    .OrderByDescending(r => r.Length)
                                    .Select(r => new
                                    {
                                        riverName = r.RiverName,
                                        riverLength = r.Length,
                                        countries = r.Countries
                                                    .OrderBy(c => c.CountryName)
                                                    .Select(c => c.CountryName)
                                    });
            //Console.WriteLine(riversQuery);
            //foreach (var river in riversQuery)
            //{
            //    Console.WriteLine(river);
            //}

            var json = new JavaScriptSerializer().Serialize(riversQuery.ToList());
            //Console.WriteLine(json);

            File.WriteAllText(@"rivers.json", json);
        }
    }
}
