using static RiotCaller.EnumAttributes;

namespace RiotCaller
{
    public enum ApiType
    {
        [IsStatic(false)]
        [Value("{region}.api.pvp.net/api/lol")]
        nonStatic,

        [IsStatic(true)]
        [Value("global.api.pvp.net/api/lol/static-data")]
        Static
    }
}