using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StaticEndPoints.Item;
using System.Linq;

namespace RiotCaller
{
    public class StaticApi : IStaticApi
    {
        public RiotApiCache Cache { get; set; }
        public StaticApi(RiotApiCache _cache)
        {
            Cache = _cache;
        }
        public StaticApi()//only for test project
        {

        }
        public Champions GetChampions(region region, language lang = language.tr_TR, champData? chamData = null)
        {
            RiotApiCaller<Champions> caller = new RiotApiCaller<Champions>(suffix.champions);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (chamData != null)
                caller.AddParam(param.champData, chamData.Value);
            else
                caller.AddParam(param.champData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public ChampionData GetChampion(long championId, region region, language lang = language.tr_TR, champData? chamData = null)
        {
            RiotApiCaller<ChampionData> caller = new RiotApiCaller<ChampionData>(suffix.championsById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, championId);
            if (chamData != null)
                caller.AddParam(param.champData, chamData.Value);
            else
                caller.AddParam(param.champData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public Items GetItems(region region, language lang = language.tr_TR, itemListData? itemListData = null)
        {
            RiotApiCaller<Items> caller = new RiotApiCaller<Items>(suffix.items);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (itemListData != null)
                caller.AddParam(param.itemListData, itemListData.Value);
            else
                caller.AddParam(param.itemListData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
        public ItemData GetItem(long itemId, region region, language lang = language.tr_TR, itemListData? itemData = null)
        {
            RiotApiCaller<ItemData> caller = new RiotApiCaller<ItemData>(suffix.item);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, itemId);
            if (itemData != null)
                caller.AddParam(param.itemData, itemData.Value);
            else
                caller.AddParam(param.itemData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
    }
}