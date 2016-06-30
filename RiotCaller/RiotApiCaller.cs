using RiotCaller.Enums;
using System.Collections.Generic;


namespace RiotCaller
{
    public class RiotApiCaller<T> where T : class
    {
        private suffix summonerByname;

        //public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();

        public List<T> Result { get; set; } = new List<T>();

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
            Url = string.Format("https://{0}/{{region}}/v{1}/{2}/{3}",
                Suffix.GetApiType().GetValue(),
                Suffix.GetApiGroup().GetVersion(),
                Suffix.GetApiGroup(),
                Suffix.GetValue()
                );

            Url = Url.Replace("/team/team/", "/team/");//bug (for => suffix.teamByIds)
        }
        
        /// <summary>
        /// suffixes may replace instead of CacheKey 
        /// </summary>
        public string CacheKey { get { return Suffix.ToString(); } }

        /// <summary>
        /// api urls 
        /// </summary>
        public suffix Suffix { get; private set; }
    }
}