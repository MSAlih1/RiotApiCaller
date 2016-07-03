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
using System.Collections.Generic;

namespace RiotCaller.Api
{
    public interface IStaticApi
    {
        RiotApiCache Cache { get; set; }

        ChampionData GetChampion(long championId, region region, language lang, champData? chamData = default(champData?));

        Champions GetChampions(region region, language lang, champData? chamData = default(champData?));

        ItemData GetItem(long itemId, region region, language lang, itemListData? itemData = default(itemListData?));

        Items GetItems(region region, language lang, itemListData? itemListData = default(itemListData?));

        List<language> GetLanguages(region region);

        LanguageStrings GetLanguageStrings(region region, language lang);

        MapData GetMaps(region region, language lang);

        MasteryData GetMasteries(region region, language lang, masteryListData? masteryData = default(masteryListData?));

        Mastery GetMastery(int masteryId, region region, language lang, masteryListData? masteryData = default(masteryListData?));

        Realm GetRealm(region region);

        RuneData GetRune(long runeId, region region, language lang, runeListData runeData = runeListData.basic);

        RuneList GetRunes(region region, language lang, runeListData runeData = runeListData.basic);

        SummonerSpellData GetSummonerSpell(long summonerSpellId, region region, language lang, spellData? spellData = default(spellData?));

        SummonerSpellList GetSummonerSpells(region region, language lang, spellData? spellData = default(spellData?));

        List<string> GetVersions(region region);
    }
}