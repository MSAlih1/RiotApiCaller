using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Mastery
{
    public class MasteryTreeListItem
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty("prereq")]
        public string prereq { get; set; }
        
    }
}