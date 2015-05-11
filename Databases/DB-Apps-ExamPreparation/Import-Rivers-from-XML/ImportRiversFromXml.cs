﻿using EF_Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Import_Rivers_from_XML
{
    class ImportRiversFromXml
    {
        static void Main()
        {
            var context = new GeographyEntities();
            var xmlDoc = XDocument.Load(@"..\..\rivers.xml");
            //Console.WriteLine(xmlDoc);
            var riverElements = xmlDoc.Root.Elements(); 
            foreach (var riverElement in riverElements)  //in xmlDoc.XPathSelectElements("/rivers/river")
            {
                var riverEntity = new River();
                riverEntity.RiverName = riverElement.Element("name").Value;
                //Console.WriteLine(riverElement.Element("name").Value);
                riverEntity.Length = int.Parse(riverElement.Element("length").Value);
                riverEntity.Outflow = riverElement.Element("outflow").Value;
                if (riverElement.Element("drainage-area")!= null)
                {
                    riverEntity.DrainageArea = int.Parse(riverElement.Element("drainage-area").Value);    
                }
                if (riverElement.Element("average-discharge") != null)
                {
                    riverEntity.AverageDischarge = int.Parse(riverElement.Element("average-discharge").Value);    
                }

                ParseAndAddCountriesToRiver(context, riverElement, riverEntity);

                context.Rivers.Add(riverEntity);
            }

            context.SaveChanges();
        }

        private static void ParseAndAddCountriesToRiver(GeographyEntities context, XElement riverElement, River riverEntity)
        {
            var countryElements = riverElement.XPathSelectElements("countries/country");
            foreach (var countryElement in countryElements)
            {
                var countryName = countryElement.Value;
                var countryEntity = context.Countries.FirstOrDefault(c => c.CountryName == countryName);
                if (countryEntity != null)
                {
                    riverEntity.Countries.Add(countryEntity);
                }
                else
                {
                    throw new Exception(string.Format("Cannot find country {0} in the DB", countryName));
                }
            }
        }
    }
}
