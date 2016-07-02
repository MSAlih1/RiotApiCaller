using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Mastery
{
    public class MasteryData
    {

        [JsonProperty("type")]
        public string Type { get; set; }


        [JsonProperty("version")]
        public string Version { get; set; }


        [JsonProperty("data")]
        public Dictionary<int, Mastery> Data { get; set; }


        [JsonProperty("tree")]
        public MasteryTrees Tree { get; set; }

    }
}
