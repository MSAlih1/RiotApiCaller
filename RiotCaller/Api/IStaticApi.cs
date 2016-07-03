using System.Collections.Generic;
using RiotCaller.Api.Cache;
using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StaticEndPoints.Item;
using RiotCaller.StaticEndPoints.LanguageStrings;
using RiotCaller.StaticEndPoints.Map;
using RiotCaller.StaticEndPoints.Mastery;
using RiotCaller.StaticEndPoints.Realm;
using RiotCaller.StaticEndPoints.Runes;
using RiotCaller.StaticEndPoints.SummonerSpells;

namespace RiotCaller.Api
{
    public interface IStaticApi
    {
        ApiCache Cache { get; }

        ChampionData GetChampion(long championId, region region, language lang, champData? chamData = default(champData?), bool useCaching = false);
        Champions GetChampions(region region, language lang, champData? chamData = default(champData?), bool useCaching = false);
        ItemData GetItem(long itemId, region region, language lang, itemListData? itemData = default(itemListData?), bool useCaching = false);
        Items GetItems(region region, language lang, itemListData? itemListData = default(itemListData?), bool useCaching = false);
        List<language> GetLanguages(region region, bool useCaching = false);
        LanguageStrings GetLanguageStrings(region region, language lang, bool useCaching = false);
        MapData GetMaps(region region, language lang, bool useCaching = false);
        MasteryData GetMasteries(region region, language lang, masteryListData? masteryData = default(masteryListData?), bool useCaching = false);
        Mastery GetMastery(int masteryId, region region, language lang, masteryListData? masteryData = default(masteryListData?), bool useCaching = false);
        Realm GetRealm(region region, bool useCaching = false);
        RuneData GetRune(long runeId, region region, language lang, runeListData runeData = runeListData.basic, bool useCaching = false);
        RuneList GetRunes(region region, language lang, runeListData runeData = runeListData.basic, bool useCaching = false);
        SummonerSpellData GetSummonerSpell(long summonerSpellId, region region, language lang, spellData? spellData = default(spellData?), bool useCaching = false);
        SummonerSpellList GetSummonerSpells(region region, language lang, spellData? spellData = default(spellData?), bool useCaching = false);
        List<string> GetVersions(region region, bool useCaching = false);
    }
}