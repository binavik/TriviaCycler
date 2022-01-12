using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TriviaCycler
{
    class SettingsData
    {
        [JsonProperty("questionTime")]
        public int timeToDisplayQuestion { get; set; }
        [JsonProperty("answerTime")]
        public int timeToDisplayAnswer { get; set; }
        [JsonProperty("fontMultiplier")]
        public float fontMultiplier { get; set; }
    }
}
