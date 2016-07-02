using Newtonsoft.Json;
using RiotCaller.Converters;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonConverter(typeof(ChampionTagConverter))]
        [JsonProperty("tags")]
        public List<championTag> Tags { get; set; }

        [JsonProperty("stats")]
        public ChampionStats Stats { get; set; }

        [JsonProperty("enemytips")]
        public List<string> Enemytips { get; set; }

        [JsonProperty("recommended")]
        public List<ChampionRecommended> Recommended { get; set; }

        [JsonProperty("image")]
        public ChampionImage Image { get; set; }

        [JsonProperty("spells")]
        public List<ChampionSpell> Spells { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("allytips")]
        public List<string> Allytips { get; set; }

        [JsonProperty("info")]
        public ChampionInfo Info { get; set; }

        [JsonProperty("lore")]
        public string Lore { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("passive")]
        public ChampionPassive Passive { get; set; }

        [JsonProperty("partype")]
        public string Partype { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("skins")]
        public List<ChampionSkin> Skins { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
