using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaCycler
{
    class SettingsData
    {
        public int timeToDisplayQuestion { get; set; }
        public int timeToDisplayAnswer { get; set; }
        public string category { get; set; }
        public float fontMultiplier { get; set; }
        public string api_key { get; set; }

    }
}
