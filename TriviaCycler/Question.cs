using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TriviaCycler
{
    class Question
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("answer")]
        public string answer { get; set; }
        [JsonProperty("question")]
        public string question { get; set; }
        [JsonProperty("value")]
        public object value { get; set; }
        [JsonProperty("airdate")]
        public DateTime airDate { get; set; }
        [JsonProperty("created_at")]
        public DateTime created { get; set; }
        [JsonProperty("updated_at")]
        public DateTime updated { get; set; }
        [JsonProperty("category_id")]
        public int categoryId { get; set; }

        [JsonProperty("game_id", NullValueHandling = NullValueHandling.Ignore)]
        public object gameId { get; set; }
        [JsonProperty("invalid_count", NullValueHandling = NullValueHandling.Ignore)]
        public object invalidCount { get; set; }
        [JsonProperty("category")]
        public Category category { get; set; }

        public class Category
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("title")]
            public string title { get; set; }
            [JsonProperty("created_at")]
            public DateTime created { get; set; }
            [JsonProperty("updated_at")]
            public DateTime updated { get; set; }
            [JsonProperty("clues_count")]
            public int cluesCount { get; set; }
        }
    }
}
