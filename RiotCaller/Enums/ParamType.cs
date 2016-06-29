namespace RiotCaller
{
    /// <summary>
    /// api url's parameters do not change type names! 
    /// </summary>
    public enum ParamType
    {
        /// <summary> Example Value => new List<string>() { summonerName1, summonerName2 } </summary>
        summonerNames,

        /// <summary> Example Value => new List<long>() { summonerId1, summonerId2 } </summary>
        summonerIds,

        /// <summary>
        /// Example Value =&gt; "variable type is long OR type of RegionEnum } 
        /// </summary>
        region,

        /// <summary>
        /// Example Value =&gt; variable type is long } 
        /// </summary>
        summonerId,

        /// <summary> Example Value => new List<long>() { teamId1, teamId2 } </summary>
        teamIds
    }
}