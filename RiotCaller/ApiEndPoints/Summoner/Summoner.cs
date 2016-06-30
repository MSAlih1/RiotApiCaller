using Newtonsoft.Json;
using RiotCaller.Attributes;
using RiotCaller.Enums;
using System;

namespace RiotCaller.ApiEndPoints
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

        public region Region;
    }
}