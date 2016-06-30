using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{

    public class Event
    {

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("itemId")]
        public int İtemId { get; set; }

        [JsonProperty("levelUpType")]
        public string LevelUpType { get; set; }

        [JsonProperty("skillSlot")]
        public int? SkillSlot { get; set; }

        [JsonProperty("itemBefore")]
        public int? İtemBefore { get; set; }

        [JsonProperty("itemAfter")]
        public int? İtemAfter { get; set; }

        [JsonProperty("creatorId")]
        public int? CreatorId { get; set; }

        [JsonProperty("wardType")]
        public string WardType { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("victimId")]
        public int? VictimId { get; set; }

        [JsonProperty("killerId")]
        public int? KillerId { get; set; }

        [JsonProperty("assistingParticipantIds")]
        public List<int> AssistingParticipantIds { get; set; }

        [JsonProperty("monsterType")]
        public string MonsterType { get; set; }

        [JsonProperty("laneType")]
        public string LaneType { get; set; }

        [JsonProperty("buildingType")]
        public string BuildingType { get; set; }

        [JsonProperty("towerType")]
        public string TowerType { get; set; }

        [JsonProperty("teamId")]
        public int? TeamId { get; set; }
    }

}
