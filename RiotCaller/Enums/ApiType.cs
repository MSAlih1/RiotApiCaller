using static RiotCaller.EnumAttributes;

namespace RiotCaller
{
    /// <summary>
    /// do not change this values 
    /// </summary>
    public enum apiType
    {
        [IsStatic(false)]
        [Value("{region}.api.pvp.net/api/lol")]
        nonStatic,

        [IsStatic(true)]
        [Value("global.api.pvp.net/api/lol/static-data")]
        Static
    }
}