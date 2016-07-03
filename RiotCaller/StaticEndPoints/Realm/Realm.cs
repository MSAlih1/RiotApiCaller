using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Realm
{
        //{
        //   "v": "6.13.1",
        //   "dd": "6.13.1",
        //   "cdn": "http://ddragon.leagueoflegends.com/cdn",
        //   "lg": "6.13.1",
        //   "n": {
        //      "champion": "6.13.1",
        //      "profileicon": "6.13.1",
        //      "item": "6.13.1",
        //      "map": "6.13.1",
        //      "mastery": "6.13.1",
        //      "language": "6.13.1",
        //      "summoner": "6.13.1",
        //      "rune": "6.13.1"
        //   },
        //   "profileiconmax": 28,
        //   "l": "tr_TR",
        //   "css": "6.13.1"
        //}
    public class Realm
    {
        [JsonProperty("v")]
        public string V { get; set; }

        [JsonProperty("dd")]
        public string Dd { get; set; }

        [JsonProperty("cdn")]
        public string Cdn { get; set; }

        [JsonProperty("lg")]
        public string Lg { get; set; }

        [JsonProperty("n")]
        public RealmData RealmData { get; set; }

        [JsonProperty("profileiconmax")]
        public int Profileiconmax { get; set; }

        [JsonProperty("l")]
        public string L { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }
    }
}
