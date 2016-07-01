﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.EndPoints.Game
{

    public class Stats
    {
        [JsonProperty("totalDamageDealtToChampions")]
        public int TotalDamageDealtToChampions { get; set; }

        [JsonProperty("item2")]
        public int Item2 { get; set; }

        [JsonProperty("goldEarned")]
        public int GoldEarned { get; set; }

        [JsonProperty("item1")]
        public int Item1 { get; set; }

        [JsonProperty("wardPlaced")]
        public int WardPlaced { get; set; }

        [JsonProperty("totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        [JsonProperty("item0")]
        public int Item0 { get; set; }

        [JsonProperty("trueDamageDealtPlayer")]
        public int TrueDamageDealtPlayer { get; set; }

        [JsonProperty("physicalDamageDealtPlayer")]
        public int PhysicalDamageDealtPlayer { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        public int TrueDamageDealtToChampions { get; set; }

        [JsonProperty("killingSprees")]
        public int KillingSprees { get; set; }

        [JsonProperty("playerRole")]
        public int PlayerRole { get; set; }

        [JsonProperty("totalUnitsHealed")]
        public int TotalUnitsHealed { get; set; }

        [JsonProperty("playerPosition")]
        public int PlayerPosition { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("neutralMinionsKilledYourJungle")]
        public int NeutralMinionsKilledYourJungle { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public int MagicDamageDealtToChampions { get; set; }

        [JsonProperty("magicDamageDealtPlayer")]
        public int MagicDamageDealtPlayer { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("magicDamageTaken")]
        public int MagicDamageTaken { get; set; }

        [JsonProperty("numDeaths")]
        public int NumDeaths { get; set; }

        [JsonProperty("totalTimeCrowdControlDealt")]
        public int TotalTimeCrowdControlDealt { get; set; }

        [JsonProperty("largestMultiKill")]
        public int LargestMultiKill { get; set; }

        [JsonProperty("physicalDamageTaken")]
        public int PhysicalDamageTaken { get; set; }

        [JsonProperty("win")]
        public bool Win { get; set; }

        [JsonProperty("team")]
        public int Team { get; set; }

        [JsonProperty("totalDamageDealt")]
        public int TotalDamageDealt { get; set; }

        [JsonProperty("largestKillingSpree")]
        public int LargestKillingSpree { get; set; }

        [JsonProperty("totalHeal")]
        public int TotalHeal { get; set; }

        [JsonProperty("item4")]
        public int Item4 { get; set; }

        [JsonProperty("item3")]
        public int Item3 { get; set; }

        [JsonProperty("item6")]
        public int Item6 { get; set; }

        [JsonProperty("item5")]
        public int Item5 { get; set; }

        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; set; }

        [JsonProperty("timePlayed")]
        public int TimePlayed { get; set; }

        [JsonProperty("wardKilled")]
        public int WardKilled { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        public int PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("championsKilled")]
        public int ChampionsKilled { get; set; }

        [JsonProperty("trueDamageTaken")]
        public int TrueDamageTaken { get; set; }

        [JsonProperty("goldSpent")]
        public int GoldSpent { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }

        [JsonProperty("visionWardsBought")]
        public int? VisionWardsBought { get; set; }

        [JsonProperty("turretsKilled")]
        public int? TurretsKilled { get; set; }

        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        public int? NeutralMinionsKilledEnemyJungle { get; set; }

        [JsonProperty("bountyLevel")]
        public int? BountyLevel { get; set; }

        [JsonProperty("doubleKills")]
        public int? DoubleKills { get; set; }

        [JsonProperty("totalScoreRank")]
        public int? TotalScoreRank { get; set; }

        [JsonProperty("totalPlayerScore")]
        public int? TotalPlayerScore { get; set; }

        [JsonProperty("victoryPointTotal")]
        public int? VictoryPointTotal { get; set; }
    }
}
