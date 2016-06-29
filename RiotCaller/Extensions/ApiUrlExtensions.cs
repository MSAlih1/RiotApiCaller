
using System;
using System.Collections.Generic;
using System.Reflection;

namespace RiotCaller
{
    /// <summary>
    /// url parameters, api key includes , begin request 
    /// </summary>
    public static class ApiUrlExtensions
    {
        /// <summary>
        /// AddParam(ParamTypes.summonerIds, new List<long>() { 466244, 457724 });
        /// AddParam(ParamTypes.region, "tr");
        /// </summary>
        public static void AddParam<T>(this ApiUrl<T> apival, ParamTypes key, object value) 
            where T : class
        {
            KeyValuePair<string, object> item = new KeyValuePair<string, object>(key.ToString(),value);
            string val = "";

            if (item.Value is List<long>)
            {
                val = string.Join(",", (item.Value as List<long>));
            }
            else if (item.Value is List<string>)
            {
                val = string.Join(",", (item.Value as List<string>));
            }
            else if (item.Value is List<int>)
            {
                val = string.Join(",", (item.Value as List<int>));
            }
            else
            {
                val = item.Value.ToString();
            }
            apival.Url = apival.Url.Replace(string.Format("{{{0}}}", item.Key.ToString()), val);
        }
    }

}