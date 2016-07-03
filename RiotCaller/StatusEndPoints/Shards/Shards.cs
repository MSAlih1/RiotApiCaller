using Newtonsoft.Json;
using RiotCaller.Converters;
using RiotCaller.Enums;
using System.Collections.Generic;

namespace RiotCaller.StatusEndPoints.Shards
{
    public class Shards
    {
        [JsonProperty("region_tag")]
        public string RegionTag { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonConverter(typeof(ChampionTagConverter<language>))]
        [JsonProperty("locales")]
        public List<language> Locales { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}