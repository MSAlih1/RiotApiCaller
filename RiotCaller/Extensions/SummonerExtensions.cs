using Ninject;
using RiotCaller.EndPoints.League;
using RiotCaller.EndPoints.MatchList;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller.ApiEndPoints
{
    public static class SummonerExtensions
    {
        public static League GetLeague(this Summoner sum)
        {
            return new StandardKernel().Get<NonStaticApi>().GetLeague(sum.Id, sum.Region);
        }

        public static MatchList GetMatchList(this Summoner sum, List<long> _championIds = null,
            List<queue> _queue = null, List<season> _seasons = null, DateTime? _beginTime = null, DateTime? _endTime = null,
            int? _beginIndex = null, int? _endIndex = null)
        {
            return new StandardKernel().Get<NonStaticApi>().GetMatchList(sum.Id, sum.Region,_championIds,_queue,_seasons,_beginTime,_endTime,_beginIndex,_endIndex);
        }

        public static Ranked GetStatsRanked(this Summoner sum, season? season = null)
        {
            return new StandardKernel().Get<NonStaticApi>().GetStatsRanked(sum.Id, sum.Region, season);
        }

        public static Summary GetStatsSummary(this Summoner sum, season? season = null)
        {
            return new StandardKernel().Get<NonStaticApi>().GetStatsSummary(sum.Id, sum.Region, season);
        }

        public static List<Team> GetTeams(this Summoner sum)
        {
            return new StandardKernel().Get<NonStaticApi>().GetTeams(new List<long>() { sum.Id }, sum.Region);
        }


    }
}