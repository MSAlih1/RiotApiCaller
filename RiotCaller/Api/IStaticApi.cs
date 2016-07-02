using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;

namespace RiotCaller
{
    public interface IStaticApi
    {
        ChampionData GetChampion(long championId, region region, language lang = language.tr_TR, champData? chamData = default(champData?));
        Champions GetChampions(region region, language lang = language.tr_TR, champData? chamData = default(champData?));
    }
}