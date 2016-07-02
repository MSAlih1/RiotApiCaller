using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionSpell
    {
        [JsonProperty("range")]
        public List<int> Range { get; set; }

        [JsonProperty("leveltip")]
        public SpellLeveltip Leveltip { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty("effectBurn")]
        public List<string> EffectBurn { get; set; }

        [JsonProperty("image")]
        public ChampionImage Image { get; set; }

        [JsonProperty("cooldown")]
        public List<double> Cooldown { get; set; }

        [JsonProperty("cost")]
        public List<int> Cost { get; set; }

        [JsonProperty("vars")]
        public List<SpellVar> Vars { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("effect")]
        public List<List<double>> Effect { get; set; }

        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }
    }
}
