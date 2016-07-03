using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Item;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Mastery
{
    public class Mastery
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public List<string> Description { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("sanitizedDescription")]
        public List<string> SanitizedDescription { get; set; }

        [JsonProperty("prereq")]
        public string prereq { get; set; }

        [JsonProperty("ranks")]
        public int Rank { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}