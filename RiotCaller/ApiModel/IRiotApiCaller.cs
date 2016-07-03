using RiotCaller.Enums;
using System.Collections.Generic;

namespace RiotCaller
{
    public interface IRiotApiCaller<T> where T : class
    {
        string CacheKey { get; }
        List<T> Result { get; set; }
        int ResultStruct { get; set; }
        suffix Suffix { get; }
        string Url { get; set; }

        string ToString();
    }
}