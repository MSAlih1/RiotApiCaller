using Newtonsoft.Json;
using RiotCaller.Attributes;
using System;
using System.Collections.Generic;

namespace RiotCaller.ApiEndPoints.Stats
{
    public class Ranked
    {
        [JsonProperty("champions")]
        public List<Champion> Champions { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("modifyDate")]
        public DateTime ModifyDate { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }

}