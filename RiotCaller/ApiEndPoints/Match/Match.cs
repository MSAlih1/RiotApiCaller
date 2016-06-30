using Newtonsoft.Json;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{
    public class MatchDetail
    {
        [JsonProperty("region")]
        public region Region { get; set; }

        [JsonProperty("matchType")]
        public string MatchType { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("matchCreation")]
        public DateTime MatchCreation { get; set; }

        [JsonProperty("timeline")]
        public Timeline Timeline { get; set; }

        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("matchMode")]
        public string MatchMode { get; set; }

        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentity> ParticipantIdentities { get; set; }

        [JsonProperty("matchVersion")]
        public string MatchVersion { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("queueType")]
        public string QueueType { get; set; }

        [JsonProperty("matchId")]
        public long MatchId { get; set; }

        [JsonProperty("matchDuration")]
        public int MatchDuration { get; set; }
    }
    public class Team
    {
        [JsonProperty("bans")]
        public List<Ban> Bans { get; set; }

        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }

        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }

        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        [JsonProperty("winner")]
        public bool Winner { get; set; }

        [JsonProperty("firstDragon")]
        public bool FirstDragon { get; set; }

        [JsonProperty("vilemawKills")]
        public int VilemawKills { get; set; }

        [JsonProperty("baronKills")]
        public int BaronKills { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("inhibitorKills")]
        public int İnhibitorKills { get; set; }

        [JsonProperty("dominionVictoryScore")]
        public int DominionVictoryScore { get; set; }

        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }

        [JsonProperty("firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }

        [JsonProperty("firstBaron")]
        public bool FirstBaron { get; set; }

        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }
    }

    public class Ban
    {
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }
    }
    public class ParticipantIdentity
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
    }
    public class Player
    {

        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }

    public class Participant
    {

        [JsonProperty("masteries")]
        public List<Mastery> Masteries { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("runes")]
        public List<Rune> Runes { get; set; }

        [JsonProperty("timeline")]
        public Timeline2 Timeline { get; set; }

        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }

        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }
    }

    public class Timeline2
    {

        [JsonProperty("xpDiffPerMinDeltas")]
        public XpDiffPerMinDeltas XpDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public DamageTakenDiffPerMinDeltas DamageTakenDiffPerMinDeltas { get; set; }

        [JsonProperty("xpPerMinDeltas")]
        public XpPerMinDeltas XpPerMinDeltas { get; set; }

        [JsonProperty("goldPerMinDeltas")]
        public GoldPerMinDeltas GoldPerMinDeltas { get; set; }

        [JsonProperty("role")]
        public role Role { get; set; }

        [JsonProperty("creepsPerMinDeltas")]
        public CreepsPerMinDeltas CreepsPerMinDeltas { get; set; }

        [JsonProperty("csDiffPerMinDeltas")]
        public CsDiffPerMinDeltas CsDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenPerMinDeltas")]
        public DamageTakenPerMinDeltas DamageTakenPerMinDeltas { get; set; }

        [JsonProperty("lane")]
        public lane Lane { get; set; }
    }

    public class DamageTakenPerMinDeltas
    {

        [JsonProperty("zeroToTen")]
        public double ZeroToTen { get; set; }

        [JsonProperty("thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        [JsonProperty("tenToTwenty")]
        public double TenToTwenty { get; set; }

        [JsonProperty("twentyToThirty")]
        public double TwentyToThirty { get; set; }
    }
    public class XpDiffPerMinDeltas
    {

        [JsonProperty("zeroToTen")]
        public double ZeroToTen { get; set; }

        [JsonProperty("thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        [JsonProperty("tenToTwenty")]
        public double TenToTwenty { get; set; }

        [JsonProperty("twentyToThirty")]
        public double TwentyToThirty { get; set; }
    }

    public class DamageTakenDiffPerMinDeltas
    {

        [JsonProperty("zeroToTen")]
        public double ZeroToTen { get; set; }

        [JsonProperty("thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        [JsonProperty("tenToTwenty")]
        public double TenToTwenty { get; set; }

        [JsonProperty("twentyToThirty")]
        public double TwentyToThirty { get; set; }
    }

    public class XpPerMinDeltas
    {

        [JsonProperty("zeroToTen")]
        public double ZeroToTen { get; set; }

        [JsonProperty("thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        [JsonProperty("tenToTwenty")]
        public double TenToTwenty { get; set; }

        [JsonProperty("twentyToThirty")]
        public double TwentyToThirty { get; set; }
    }

    public class GoldPerMinDeltas
    {

        [JsonProperty("zeroToTen")]
        public double ZeroToTen { get; set; }

        [JsonProperty("thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        [JsonProperty("tenToTwenty")]
        public double TenToTwenty { get; set; }

        [JsonProperty("twentyToThirty")]
        public double TwentyToThirty { get; set; }
    }

    public class CreepsPerMinDeltas
    {

        [JsonProperty("zeroToTen")]
        public double ZeroToTen { get; set; }

        [JsonProperty("thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        [JsonProperty("tenToTwenty")]
        public double TenToTwenty { get; set; }

        [JsonProperty("twentyToThirty")]
        public double TwentyToThirty { get; set; }
    }

    public class CsDiffPerMinDeltas
    {

        [JsonProperty("zeroToTen")]
        public double ZeroToTen { get; set; }

        [JsonProperty("thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        [JsonProperty("tenToTwenty")]
        public double TenToTwenty { get; set; }

        [JsonProperty("twentyToThirty")]
        public double TwentyToThirty { get; set; }
    }

    public class Rune
    {

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("runeId")]
        public int RuneId { get; set; }
    }
    public class Stats
    {
        [JsonProperty("unrealKills")]
        public int UnrealKills { get; set; }

        [JsonProperty("item2")]
        public int İtem2 { get; set; }

        [JsonProperty("item1")]
        public int İtem1 { get; set; }

        [JsonProperty("totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        [JsonProperty("item0")]
        public int İtem0 { get; set; }

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
        public int İnhibitorKills { get; set; }

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
        public int İtem4 { get; set; }

        [JsonProperty("item3")]
        public int İtem3 { get; set; }

        [JsonProperty("objectivePlayerScore")]
        public int ObjectivePlayerScore { get; set; }

        [JsonProperty("item6")]
        public int İtem6 { get; set; }

        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        [JsonProperty("item5")]
        public int İtem5 { get; set; }

        [JsonProperty("trueDamageTaken")]
        public int TrueDamageTaken { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }

        [JsonProperty("combatPlayerScore")]
        public int CombatPlayerScore { get; set; }
    }

    public class Mastery
    {

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }
    }

    public class Timeline
    {

        [JsonProperty("frameInterval")]
        public int FrameInterval { get; set; }

        [JsonProperty("frames")]
        public List<Frame> Frames { get; set; }
    }
    public class Frame
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("participantFrames")]
        public ParticipantFrames ParticipantFrames { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }
    }
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
    public class Position
    {
        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }
    }
    public class ParticipantFrames
    {
        public List<Frames1> frames { get; set; }
    }
    public class Frames1
    {
        [JsonProperty("currentGold")]
        public int CurrentGold { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }

        [JsonProperty("totalGold")]
        public int TotalGold { get; set; }

        [JsonProperty("dominionScore")]
        public int DominionScore { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("xp")]
        public int Xp { get; set; }

        [JsonProperty("teamScore")]
        public int TeamScore { get; set; }
    }
}
