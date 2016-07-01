using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.EndPoints.ChampionRotation
{
    public class ChampionStatus
    {
        [JsonProperty("botMmEnabled")]
        public bool BotMmEnabled { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }

        [JsonProperty("botEnabled")]
        public bool BotEnabled { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }
    }
}
