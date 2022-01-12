using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TriviaCycler
{
    class Category
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("created_at")]
        public string created { get; set; }
        [JsonProperty("updated_at")]
        public string updated { get; set; }
        [JsonProperty("clues_count")]
        public int cluesCount { get; set; }
    }
}
