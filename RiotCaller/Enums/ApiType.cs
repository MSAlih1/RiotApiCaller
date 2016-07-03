using RiotCaller.Attributes;

namespace RiotCaller.Enums
{
    /// <summary>
    /// do not change this values 
    /// </summary>

    /// IsStatic = 0 (status) 
    /// IsStatic = 1 (nonStatic) 
    /// IsStatic = 2 (Static)
    /// IsStatic = 3 (CurrentGame)
    public enum apiType
    {
        [IsStatic(1)]
        [Value("{region}.api.pvp.net/api/lol")]
        nonStatic,

        [IsStatic(2)]
        [Value("global.api.pvp.net/api/lol/static-data")]
        Static,

        [IsStatic(0)]
        [Value("status.leagueoflegends.com")]
        Status,

        [IsStatic(3)]
        [Value("{region}.api.pvp.net/observer-mode/rest/consumer")]
        CurrentGame
    }
}