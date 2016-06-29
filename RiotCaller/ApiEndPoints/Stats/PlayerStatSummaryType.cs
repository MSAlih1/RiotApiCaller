using Newtonsoft.Json;
using RiotCaller.Attributes;

namespace RiotCaller.ApiEndPoints.Stats
{
    [JsonConverter(typeof(StatsSummaryType))]
    public enum PlayerStatsSummaryType
    {
        RankedPremade3x3,

        RankedPremade5x5,

        CoopVsAI3x3,

        AramUnranked5x5,

        CAP5x5,

        URF,

        URFBots,

        NightmareBot,

        Ascension,

        FirstBlood1x1,

        FirstBlood2x2,

        Bilgewater,

        CoopVsAI,

        OdinUnranked,

        RankedTeam3x3,

        RankedSolo5x5,

        Unranked3x3,

        Hexakill,

        KingPoro,

        CounterPick,

        OneForAll5x5,

        RankedTeam5x5,

        Unranked,

        SummonersRift6x6
    }
}