using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BusinessgameAssistant.ObjectTypes;

namespace BusinessgameXMLFileAnomalyDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            //industry k = new 
            //MainPage.
            var industries = getIndustries();
            foreach (var industry in industries)
            {
                if (industry.price == 0)
                    Console.WriteLine(industry.name + " has no purchase price!");
                if (industry.price < 0)
                    Console.WriteLine(industry.name + " has a negative purchase price!");
                if (industry.machinery.Length == 0)
                    Console.WriteLine(industry.name + " has no required machinary!");
                if (industry.machinery.Length == 0)
                    Console.WriteLine(industry.name + " has no required machinary!");
                if (industry.machinery.Length > 0)
                    foreach (var machine in industry.machinery)
                        if (machine.amount < 1)
                            Console.WriteLine($"{industry.name} requires {machine.amount} {machine.name} machines???");
                foreach (var input in industry.input)
                    if (input.amount < 1)
                        Console.WriteLine($"{industry.name} takes {input.amount} {input.name} input???");
                foreach (var output in industry.output)
                    if (output.amount < 1)
                        Console.WriteLine($"{industry.name} generates {output.amount} {output.name} output???");
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static List<industry> getIndustries()
        {
            var deserializer = new XmlSerializer(typeof(industries));
            industries root = null;
            using (var reader = XmlReader.Create(new StringReader(getXML("https://businessgame.be/xml/industries.xml"))))
            {
                root = (industries)deserializer.Deserialize(reader);
            }
            return root.industry.ToList();
        }

        private static List<product> getProducts()
        {
            var deserializer = new XmlSerializer(typeof(products));
            products root = null;
            using (var reader = XmlReader.Create(new StringReader(getXML("https://businessgame.be/xml/products.xml"))))
            {
                root = (products)deserializer.Deserialize(reader);
            }
            return root.product.ToList();
        }

        private static string getXML(string url)
        {
            string result = "ERROR";
            var webRequest = WebRequest.Create(url);

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                reader.ReadLine();
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}
