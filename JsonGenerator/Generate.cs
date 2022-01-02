using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonGenerator
{
    public static class Generate
    {
        public class metadata{

            public string name { get; set; }
            public string symbol { get; set; }
            public string description { get; set; }
            public int seller_fee_basis_points { get; set; }
            public string image { get; set; }
            public string external_url { get; set; }
            public List<attributes> attributes { get; set; }
            public collection collection { get; set; }
            public properties properties { get; set; }

        }

        public class properties
        {
            public List<files> files { get; set; }
            public string category { get; set; }
            public List<creators> creators { get; set; }
        }

        public class attributes
        {
            public string trait_type { get; set; }
            public string value { get; set; }
        }

        public class collection
        {
            public string name { get; set; }
            public string family { get; set; }
        }

        public class files
        {
            public string url { get; set; }
            public string type { get; set; }
        }

        public class creators
        {
            public string address { get; set; }
            public int share { get; set; }
        }
        public static void create(int i)
        {
            var metadata = new metadata
            {
                name = "asdas" + " " + i,
                symbol = "",
                description = "test",
                seller_fee_basis_points = 250,
                image = "image.png",
                attributes = new List<attributes>
                {
                    new attributes()
                    {
                        trait_type = "dsada",
                        value = "daads"
                    }

                },
                collection = new collection
                {
                    name = "dsdada",
                    family = "dsds"
                },
                properties = new properties()
                {
                    files = new List<files>
                    {
                        new files()
                        {
                            url = "dsada",
                            type = "dsdas"
                        }
                    },
                    category = "dasd",
                    creators = new List<creators>
                    {
                        new creators()
                        {
                            address = "sadasdasdsadas",
                            share = 100
                        }
                        
                    }
                }
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(metadata, options);

            File.WriteAllText(@"C:\Users\selfn\Desktop\New folder\" + i + ".json", jsonString);
            Console.WriteLine(jsonString);
        }
    }
}
