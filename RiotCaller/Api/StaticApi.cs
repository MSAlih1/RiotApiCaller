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
using System.Linq;

namespace RiotCaller.Api
{
    public class StaticApi : IStaticApi
    {
        public ApiCache Cache { get; private set; }

        public StaticApi(ApiCache _cache)
        {
            Cache = _cache;
        }

        public StaticApi()//only for test project
        {
        }

        public Champions GetChampions(region region, language lang, champData? chamData = null, bool useCaching = false)
        {
            Champions val = Cache.Get<Champions>(region.ToString(), lang.ToString(), chamData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<Champions> caller = new RiotApiCaller<Champions>(suffix.champions);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (chamData != null)
                caller.AddParam(param.champData, chamData.Value);
            else
                caller.AddParam(param.champData, "");//important for basic information

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public ChampionData GetChampion(long championId, region region, language lang, champData? chamData = null, bool useCaching = false)
        {
            ChampionData val = Cache.Get<ChampionData>(championId.ToString(), region.ToString(), lang.ToString(), chamData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<ChampionData> caller = new RiotApiCaller<ChampionData>(suffix.championsById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, championId);
            if (chamData != null)
                caller.AddParam(param.champData, chamData.Value);
            else
                caller.AddParam(param.champData, "");//important for basic information

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public Items GetItems(region region, language lang, itemListData? itemListData = null, bool useCaching = false)
        {
            Items val = Cache.Get<Items>(region.ToString(), lang.ToString(), itemListData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<Items> caller = new RiotApiCaller<Items>(suffix.items);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (itemListData != null)
                caller.AddParam(param.itemListData, itemListData.Value);
            else
                caller.AddParam(param.itemListData, "");//important for basic information

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public ItemData GetItem(long itemId, region region, language lang, itemListData? itemData = null, bool useCaching = false)
        {
            ItemData val = Cache.Get<ItemData>(itemId.ToString(), region.ToString(), lang.ToString(), itemData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<ItemData> caller = new RiotApiCaller<ItemData>(suffix.item);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, itemId);
            if (itemData != null)
                caller.AddParam(param.itemData, itemData.Value);
            else
                caller.AddParam(param.itemData, "");//important for basic information

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public LanguageStrings GetLanguageStrings(region region, language lang, bool useCaching = false)
        {
            LanguageStrings val = Cache.Get<LanguageStrings>(region.ToString(), lang.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<LanguageStrings> caller = new RiotApiCaller<LanguageStrings>(suffix.languageStrings);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public List<language> GetLanguages(region region, bool useCaching = false)
        {
            List<language> val = Cache.Get<List<language>>(region.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<List<language>> caller = new RiotApiCaller<List<language>>(suffix.languages);
            caller.AddParam(param.region, region);

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public MapData GetMaps(region region, language lang, bool useCaching = false)
        {
            MapData val = Cache.Get<MapData>(region.ToString(), lang.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<MapData> caller = new RiotApiCaller<MapData>(suffix.map);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public MasteryData GetMasteries(region region, language lang, masteryListData? masteryData = null, bool useCaching = false)
        {
            MasteryData val = Cache.Get<MasteryData>(region.ToString(), lang.ToString(), masteryData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<MasteryData> caller = new RiotApiCaller<MasteryData>(suffix.mastery);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (masteryData != null)
                caller.AddParam(param.masteryListData, masteryData);
            else
                caller.AddParam(param.masteryListData, "");//important for basic information

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public Mastery GetMastery(int masteryId, region region, language lang, masteryListData? masteryData = null, bool useCaching = false)
        {
            Mastery val = Cache.Get<Mastery>(masteryId.ToString(), region.ToString(), lang.ToString(), masteryData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<Mastery> caller = new RiotApiCaller<Mastery>(suffix.masteryById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, masteryId);
            if (masteryData != null)
                caller.AddParam(param.masteryData, masteryData);
            else
                caller.AddParam(param.masteryData, "");//important for basic information

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public Realm GetRealm(region region, bool useCaching = false)
        {
            Realm val = Cache.Get<Realm>(region.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<Realm> caller = new RiotApiCaller<Realm>(suffix.realm);
            caller.AddParam(param.region, region);

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public RuneList GetRunes(region region, language lang, runeListData runeData = runeListData.basic, bool useCaching = false)
        {
            RuneList val = Cache.Get<RuneList>(region.ToString(), lang.ToString(), runeData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<RuneList> caller = new RiotApiCaller<RuneList>(suffix.runes);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.runeListData, runeData);

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public RuneData GetRune(long runeId, region region, language lang, runeListData runeData = runeListData.basic, bool useCaching = false)
        {
            RuneData val = Cache.Get<RuneData>(runeId.ToString(), region.ToString(), lang.ToString(), runeData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<RuneData> caller = new RiotApiCaller<RuneData>(suffix.runeById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, runeId);
            caller.AddParam(param.runeData, runeData);

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public SummonerSpellList GetSummonerSpells(region region, language lang, spellData? spellData = null, bool useCaching = false)
        {
            SummonerSpellList val = Cache.Get<SummonerSpellList>(region.ToString(), lang.ToString(), spellData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<SummonerSpellList> caller = new RiotApiCaller<SummonerSpellList>(suffix.summonerSpells);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (spellData != null)
                caller.AddParam(param.spellData, spellData);
            else
                caller.AddParam(param.spellData, "");//important for basic information

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public SummonerSpellData GetSummonerSpell(long summonerSpellId, region region, language lang, spellData? spellData = null, bool useCaching = false)
        {
            SummonerSpellData val = Cache.Get<SummonerSpellData>(summonerSpellId.ToString(), region.ToString(), lang.ToString(), spellData.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<SummonerSpellData> caller = new RiotApiCaller<SummonerSpellData>(suffix.summonerSpellById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, summonerSpellId);
            if (spellData != null)
                caller.AddParam(param.spellData, spellData);
            else
                caller.AddParam(param.spellData, "");//important for basic information

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }

        public List<string> GetVersions(region region, bool useCaching = false)
        {
            List<string> val = Cache.Get<List<string>>(region.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<List<string>> caller = new RiotApiCaller<List<string>>(suffix.versionList);
            caller.AddParam(param.region, region);

            if (useCaching)//your choice
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(1, 0, 0, 0)));// cache adding
            else
                caller.CreateRequest();//everytime data coming from riotgames server

            return caller.Result.FirstOrDefault();
        }
    }
}