using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BusinessgameAssistant.ObjectTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace BusinessgameAssistant.Pages
{
    public class MainPageModel : PageModel
    {
        public static string sUsername = "CrazyJap";
        public string Username;

        public List<industry> industries;
        public List<product> products;
        public profile userData;

        //public string sIndustries;
        //public string sProducts;
        //public string sUserData;

        public Dictionary<int, int> industryCounts = new Dictionary<int, int>();
        public Dictionary<int, int> industryBaseLines = new Dictionary<int, int>();


        public IActionResult OnGet()
        {
           
            sUsername += "2";
            Username = sUsername;

            industries = getIndustries();
            products = getProducts();

            string apiCode = "ERROR";
            bool cookieFound = Request.Cookies.TryGetValue("UserAPICode", out apiCode);

            userData = getUserData(apiCode);

            //JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            //{
            //    Converters = new List<JsonConverter> { new BigIntegerConverter() }
            //};
            //sIndustries = JsonConvert.SerializeObject(industries);
            //sProducts = JsonConvert.SerializeObject(products);
            //sUserData = JsonConvert.SerializeObject(userData);


            if (userData.username != null)
            {
                return Page();
            }
            else
            {
                return Redirect("BadCode");
            }
        }

        private List<industry> getIndustries()
        {
            var deserializer = new XmlSerializer(typeof(industries));
            industries root = null;
            using (var reader = XmlReader.Create(new StringReader(getXML("https://businessgame.be/xml/industries.xml"))))
            {
                root = (industries)deserializer.Deserialize(reader);
            }
            return root.industry.ToList();            
        }

        private List<product> getProducts()
        {
            var deserializer = new XmlSerializer(typeof(products));
            products root = null;
            using (var reader = XmlReader.Create(new StringReader(getXML("https://businessgame.be/xml/products.xml"))))
            {
                root = (products)deserializer.Deserialize(reader);
            }
            return root.product.ToList();
        }

        private profile getUserData(string code)
        {
            var deserializer = new XmlSerializer(typeof(profile));
            profile root = null;
            using (var reader = XmlReader.Create(new StringReader(getXML("https://businessgame.be/xml/profile/" + code + ".xml"))))
            {
                root = (profile)deserializer.Deserialize(reader);
            }
            return root;
        }

        private string getXML(string url)
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

    //class BigIntegerConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type objectType)
    //    {
    //        return (objectType == typeof(Org.BouncyCastle.Math.BigInteger));
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        System.Numerics.BigInteger big = (System.Numerics.BigInteger)reader.Value;
    //        return new Org.BouncyCastle.Math.BigInteger(big.ToString());
    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        writer.WriteRawValue(value.ToString());
    //    }
    //}
}