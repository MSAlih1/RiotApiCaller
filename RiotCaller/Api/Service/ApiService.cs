using RiotCaller.Api.Cache;
using RiotCaller.EndPoints.FuturedGames;
using RiotCaller.Enums;
using RiotCaller.NonStaticEndPoints.CurrentGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RiotCaller.Api.Service
{
    /// <summary>
    /// # use InSingletonScope with Ninject # 
    /// </summary>
    public class ApiService : IApiService
    {
        public StatusApi Status { get; private set; }
        public NonStaticApi Api { get; private set; }
        public StaticApi staticApi { get; private set; }
        public ApiCache apiCache { get; private set; }

        public ApiService()
        {
            apiCache = new ApiCache();
            Api = new NonStaticApi(apiCache);
            staticApi = new StaticApi(apiCache);
            Status = new StatusApi(apiCache);
        }

        /// <summary>
        /// all values searching in cached values
        /// </summary>
        /// <param name="c"></param>
        public void SmartProperty(GameList c)
        {
            foreach (BannedChampion _champion in c.BannedChampions)
            {
                _champion.Champion = staticApi.GetChampions(c.PlatformId.ToRegion(), c.PlatformId.ToLanguage(), champData.all, true)
                    .Data.Where(p => p.Value.Id == _champion.ChampionId)
                    .FirstOrDefault()
                    .Value;
            }

            foreach (Participant _player in c.Participants)
            {
                _player.Champion = staticApi.GetChampions(c.PlatformId.ToRegion(), c.PlatformId.ToLanguage(), champData.all, true)
                    .Data.Where(p => p.Value.Id == _player.ChampionId)
                    .FirstOrDefault()
                    .Value;

                _player.Spell1 = staticApi.GetSummonerSpells(c.PlatformId.ToRegion(), c.PlatformId.ToLanguage(), spellData.all, true)
                    .SummonerSpells.Where(p => p.Value.Id == _player.Spell1Id)
                    .FirstOrDefault()
                    .Value;

                _player.Spell2 = staticApi.GetSummonerSpells(c.PlatformId.ToRegion(), c.PlatformId.ToLanguage(), spellData.all, true)
                   .SummonerSpells.Where(p => p.Value.Id == _player.Spell2Id)
                   .FirstOrDefault()
                   .Value;

                foreach (var _rune in _player.Runes)
                {
                    _rune.RuneInfo = staticApi.GetRunes(c.PlatformId.ToRegion(), c.PlatformId.ToLanguage(), runeListData.all, true)
                         .Runes[_rune.RuneId];
                }
                foreach (var _mastery in _player.Masteries)
                {
                    _mastery.MasteryInfo = staticApi.GetMasteries(c.PlatformId.ToRegion(), c.PlatformId.ToLanguage(), masteryListData.all, true)
                         .Data[_mastery.MasteryId];
                }

            }
        }
        /// <summary>
        /// all values searching in cached values
        /// </summary>
        /// <param name="c"></param>
        public void Smartproperty(CurrentGame c)
        {
            SmartProperty(c as GameList);
        }

    }
}