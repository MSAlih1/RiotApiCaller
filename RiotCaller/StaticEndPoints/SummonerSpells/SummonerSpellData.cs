using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StaticEndPoints.Item;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.SummonerSpells
{
    public class SummonerSpellData
    {
        [JsonProperty("cooldown")]
        public List<float> Cooldowns { get; set; }

        [JsonProperty("cost")]
        public List<int> Costs { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("effect")]
        public List<List<double>> Effects { get; set; }

        [JsonProperty("effectBurn")]
        public List<string> EffectBurns { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("leveltip")]
        public LevelTipStatic LevelTip { get; set; }

        [JsonProperty("maxrank")]
        public int MaxRank { get; set; }

        [JsonProperty("modes")]
        public List<string> Modes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty("range")]
        public object Range { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("vars")]
        public List<VarStatic> Vars { get; set; }
    }
}