using System.Collections.Generic;

namespace RiotCaller
{
    /// <summary>
    /// url parameters, api key includes , begin request 
    /// </summary>
    public static class ApiUrlExtensions
    {
        /// <summary> Example => AddParam(ParamTypes.summonerIds, new List<long>() { 466244, 457724
        /// }); Example => AddParam(ParamTypes.region, "tr"); </summary>
        public static void AddParam<T>(this ApiUrl<T> apival, ParamType key, object value)
            where T : class
        {
            string val = "";
            if (value is List<long>)
                val = string.Join(",", (value as List<long>));
            else if (value is List<string>)
                val = string.Join(",", (value as List<string>));
            else if (value is List<int>)
                val = string.Join(",", (value as List<int>));
            /*
             NEED CONTROL FOR DATETIME
             */
            else
                val = value.ToString();

            apival.Url = apival.Url.Replace(string.Format("{{{0}}}", key.ToString()), val);
        }
    }
}