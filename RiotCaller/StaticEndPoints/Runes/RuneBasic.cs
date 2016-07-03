using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Item;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Runes
{
    public class RuneBasic
    {
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("stats")]
        public StaticStats Stats { get; set; }

        [JsonProperty("into")]
        public List<string> Into { get; set; }

        [JsonProperty("consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        [JsonProperty("image")]
        public object Image { get; set; }

        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("stacks")]
        public int Stacks { get; set; }

        [JsonProperty("from")]
        public List<string> From { get; set; }

        [JsonProperty("rune")]
        public StaticRune Rune { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonProperty("inStore")]
        public bool InStore { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("specialRecipe")]
        public int SpecialRecipe { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("consumed")]
        public bool Consumed { get; set; }

        [JsonProperty("maps")]
        public Dictionary<string, bool> Maps { get; set; }

        [JsonProperty("hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gold")]
        public StaticGold Gold { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }
}