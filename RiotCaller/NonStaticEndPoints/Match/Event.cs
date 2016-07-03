using Newtonsoft.Json;
using RiotCaller.Enums;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Match
{
    public class Event
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("eventType")]
        public eventType? EventType { get; set; }

        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        [JsonProperty("levelUpType")]
        public string LevelUpType { get; set; }

        [JsonProperty("skillSlot")]
        public int? SkillSlot { get; set; }

        [JsonProperty("itemBefore")]
        public int? ItemBefore { get; set; }

        [JsonProperty("itemAfter")]
        public int? ItemAfter { get; set; }

        [JsonProperty("creatorId")]
        public int? CreatorId { get; set; }

        [JsonProperty("wardType")]
        public wardType? WardType { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("victimId")]
        public int? VictimId { get; set; }

        [JsonProperty("killerId")]
        public int? KillerId { get; set; }

        [JsonProperty("assistingParticipantIds")]
        public List<int> AssistingParticipantIds { get; set; }

        [JsonProperty("monsterType")]
        public monsterType? MonsterType { get; set; }

        [JsonProperty("laneType")]
        public laneType? LaneType { get; set; }

        [JsonProperty("buildingType")]
        public buildingType? BuildingType { get; set; }

        [JsonProperty("towerType")]
        public towerType? TowerType { get; set; }

        [JsonProperty("teamId")]
        public int? TeamId { get; set; }
    }
}