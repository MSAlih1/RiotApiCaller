using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller
{
    public enum ParamTypes
    {
        /// <summary>
        /// Example Value => new List<string>() { summonerName1, summonerName2 }
        /// </summary>
        summonerNames,
        /// <summary>
        /// Example Value => new List<long>() { summonerId1, summonerId2 }
        /// </summary>
        summonerIds,
        /// <summary>
        /// Example Value => "variable type is long OR type of RegionEnum }
        /// </summary>
        region,
        /// <summary>
        /// Example Value => variable type is long }
        /// </summary>
        summonerId,
        /// <summary>
        /// Example Value => new List<long>() { teamId1, teamId2 }
        /// </summary>
        teamIds
    }
}
