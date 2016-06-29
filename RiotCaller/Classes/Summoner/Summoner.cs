using Newtonsoft.Json;
using RiotCaller.Attributes;
using System;
using static RiotCaller.EnumAttributes;

namespace RiotCaller.Classes.Summoner
{
    public class Summoner
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        
        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("revisionDate")]
        public DateTime RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}