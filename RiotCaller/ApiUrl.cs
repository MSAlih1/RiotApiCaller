namespace RiotCaller
{
    public class ApiUrl<T> where T : class
    {
        /// <summary>
        /// raw url 
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// url formatter 
        /// </summary>
        /// <param name="_suffix">
        /// </param>
        public ApiUrl(Suffix _suffix)
        {
            Suffix = _suffix;
            Url = string.Format("https://{0}/{{region}}/v{1}/{2}/{3}",
                Suffix.GetApiType().GetValue(),
                Suffix.GetApiGrop().GetVersion(),
                Suffix.GetApiGrop(),
                Suffix.GetValue()
                );
        }

        /// <summary>
        /// suffixes may replace instead of CacheKey 
        /// </summary>
        public string CacheKey { get { return Suffix.ToString(); } }

        /// <summary>
        /// api urls 
        /// </summary>
        public Suffix Suffix { get; private set; }
    }
}