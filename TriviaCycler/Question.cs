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
        [JsonProperty("category")]
        public string category { get; set; }
        [JsonProperty("question")]
        public string question { get; set; }
        [JsonProperty("answer")]
        public string answer { get; set; }
    }
}
