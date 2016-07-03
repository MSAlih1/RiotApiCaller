using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Item
{
    public class ItemData
    {
        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("consumed")]
        public bool Consumed { get; set; }

        [JsonProperty("consumeOnFull")]
        public bool ConsumOnFull { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("from")]
        public List<string> From { get; set; }

        [JsonProperty("gold")]
        public StaticGold Gold { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("inStore")]
        public bool InStore { get; set; }

        [JsonProperty("into")]
        public List<int> Into { get; set; }

        [JsonProperty("maps")]
        public Dictionary<string, bool> Maps { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plaintext")]
        public string PlainText { get; set; }

        [JsonProperty("requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonProperty("rune")]
        public StaticRune Rune { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("specialRecipe")]
        public int SpecialRecipe { get; set; }

        [JsonProperty("stacks")]
        public int Stacks { get; set; }

        [JsonProperty("stats")]
        public StaticStats Stats { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}