using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonUtil
{
    class Util
    {
        public Item LoadJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                Item item = JsonConvert.DeserializeObject<Item>(json);
                return item;
            }
        }
    }

    public class Item
    {
        [JsonProperty("firstName")]
        public string[] FirstName { get; set; }
        [JsonProperty("lastName")]
        public string[] LastName { get; set; }
        [JsonProperty("month")]
        public string[] Month { get; set; }
    }
}