﻿using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using System.Linq;

namespace RiotCaller
{
    public class StaticApi
    {
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
    }
}