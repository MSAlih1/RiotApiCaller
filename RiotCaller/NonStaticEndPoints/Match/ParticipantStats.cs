using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Match
{
    public class ParticipantStats
    {
        [JsonProperty("unrealKills")]
        public int UnrealKills { get; set; }

        [JsonProperty("item2")]
        public int Item2 { get; set; }

        [JsonProperty("item1")]
        public int Item1 { get; set; }

        [JsonProperty("totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        [JsonProperty("item0")]
        public int Item0 { get; set; }

        [JsonProperty("pentaKills")]
        public int PentaKills { get; set; }

        [JsonProperty("sightWardsBoughtInGame")]
        public int SightWardsBoughtInGame { get; set; }

        [JsonProperty("winner")]
        public bool Winner { get; set; }

        [JsonProperty("magicDamageDealt")]
        public int MagicDamageDealt { get; set; }

        [JsonProperty("wardsKilled")]
        public int WardsKilled { get; set; }

        [JsonProperty("largestCriticalStrike")]
        public int LargestCriticalStrike { get; set; }

        [JsonProperty("trueDamageDealt")]
        public int TrueDamageDealt { get; set; }

        [JsonProperty("doubleKills")]
        public int DoubleKills { get; set; }

        [JsonProperty("physicalDamageDealt")]
        public int PhysicalDamageDealt { get; set; }

        [JsonProperty("tripleKills")]
        public int TripleKills { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public int MagicDamageDealtToChampions { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("visionWardsBoughtInGame")]
        public int VisionWardsBoughtInGame { get; set; }

        [JsonProperty("totalTimeCrowdControlDealt")]
        public int TotalTimeCrowdControlDealt { get; set; }

        [JsonProperty("champLevel")]
        public int ChampLevel { get; set; }

        [JsonProperty("physicalDamageTaken")]
        public int PhysicalDamageTaken { get; set; }

        [JsonProperty("totalDamageDealt")]
        public int TotalDamageDealt { get; set; }

        [JsonProperty("largestKillingSpree")]
        public int LargestKillingSpree { get; set; }

        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; set; }

        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        public int PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("quadraKills")]
        public int QuadraKills { get; set; }

        [JsonProperty("goldSpent")]
        public int GoldSpent { get; set; }

        [JsonProperty("totalDamageDealtToChampions")]
        public int TotalDamageDealtToChampions { get; set; }

        [JsonProperty("goldEarned")]
        public int GoldEarned { get; set; }

        [JsonProperty("neutralMinionsKilledTeamJungle")]
        public int NeutralMinionsKilledTeamJungle { get; set; }

        [JsonProperty("firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        [JsonProperty("firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        [JsonProperty("wardsPlaced")]
        public int WardsPlaced { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        public int TrueDamageDealtToChampions { get; set; }

        [JsonProperty("killingSprees")]
        public int KillingSprees { get; set; }

        [JsonProperty("firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }

        [JsonProperty("totalScoreRank")]
        public int TotalScoreRank { get; set; }

        [JsonProperty("totalUnitsHealed")]
        public int TotalUnitsHealed { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("firstInhibitorAssist")]
        public bool FirstInhibitorAssist { get; set; }

        [JsonProperty("totalPlayerScore")]
        public int TotalPlayerScore { get; set; }

        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        public int NeutralMinionsKilledEnemyJungle { get; set; }

        [JsonProperty("magicDamageTaken")]
        public int MagicDamageTaken { get; set; }

        [JsonProperty("largestMultiKill")]
        public int LargestMultiKill { get; set; }

        [JsonProperty("totalHeal")]
        public int TotalHeal { get; set; }

        [JsonProperty("item4")]
        public int Item4 { get; set; }

        [JsonProperty("item3")]
        public int Item3 { get; set; }

        [JsonProperty("objectivePlayerScore")]
        public int ObjectivePlayerScore { get; set; }

        [JsonProperty("item6")]
        public int Item6 { get; set; }

        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        [JsonProperty("item5")]
        public int Item5 { get; set; }

        [JsonProperty("trueDamageTaken")]
        public int TrueDamageTaken { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }

        [JsonProperty("combatPlayerScore")]
        public int CombatPlayerScore { get; set; }
    }
}