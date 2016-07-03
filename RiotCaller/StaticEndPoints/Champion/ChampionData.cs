using Newtonsoft.Json;
using RiotCaller.Converters;
using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Item;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionData
    {
        [JsonProperty("allytips")]
        public List<string> Allytips { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("enemytips")]
        public List<string> Enemytips { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("info")]
        public ChampionInfo Info { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("lore")]
        public string Lore { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("partype")]
        public string Partype { get; set; }

        [JsonProperty("passive")]
        public ChampionPassive Passive { get; set; }

        [JsonProperty("recommended")]
        public List<ChampionRecommended> Recommended { get; set; }

        [JsonProperty("skins")]
        public List<ChampionSkin> Skins { get; set; }

        [JsonProperty("spells")]
        public List<ChampionSpell> Spells { get; set; }

        [JsonProperty("stats")]
        public ChampionStats Stats { get; set; }

        [JsonConverter(typeof(ChampionTagConverter<championTag>))]
        [JsonProperty("tags")]
        public List<championTag> Tags { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}