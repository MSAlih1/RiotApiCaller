using RiotCaller.Enums;
using System.Collections.Generic;

namespace RiotCaller
{
    public class RiotApiCaller<T> : IRiotApiCaller<T> where T : class
    {
        //public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();

        public List<T> Result { get; set; } = new List<T>();
        public int ResultStruct { get; set; }

        /// <summary>
        /// raw url 
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// url formatter 
        /// </summary>
        /// <param name="_suffix">
        /// </param>
        public RiotApiCaller(suffix _suffix)
        {
            Suffix = _suffix;
            if (_suffix == suffix.featuredGames || _suffix == suffix.championMasteries ||
                _suffix == suffix.championMasteryScore || _suffix == suffix.championMasteryTop || _suffix == suffix.championMastery)
            {
                Url = string.Format("https://{0}/{1}",
                    Suffix.GetApiType().GetValue(),
                       Suffix.GetValue()
                       );
                Url = Url.Replace("api/lol/", "");//BUG: fix it
            }
            else
            {
                Url = string.Format("https://{0}/{{region}}/v{1}/{2}/{3}",
                       Suffix.GetApiType().GetValue(),
                       Suffix.GetApiGroup().GetVersion(),
                       Suffix.GetApiGroup().ToString2(),
                       Suffix.GetValue()
                       );
                Url = Url.Replace("/team/team/", "/team/");//BUG: fix it (for => suffix.teamByIds)
                Url = Url.Replace("championRotation/", "");//BUG suffix.championRotation, suffix.championRotation
            }

        }

        /// <summary>
        /// suffixes may replace instead of CacheKey 
        /// </summary>
        public string CacheKey { get { return Suffix.ToString(); } }

        /// <summary>
        /// api urls 
        /// </summary>
        public suffix Suffix { get; private set; }

        public override string ToString()
        {
            return Url;
        }
    }
}