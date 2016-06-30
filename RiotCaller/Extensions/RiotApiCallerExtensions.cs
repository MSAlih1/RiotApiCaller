using Newtonsoft.Json;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace RiotCaller
{
    /// <summary>
    /// url parameters, api key includes , begin request 
    /// </summary>
    public static class RiotApiCallerExtensions
    {
        /// <summary> Example => AddParam(ParamTypes.summonerIds, new List<long>() { 466244, 457724
        /// }); Example => AddParam(ParamTypes.region, "tr"); </summary>
        public static void AddParam<T>(this RiotApiCaller<T> apiurl, param key, object value) where T : class
        {
            string val = "";
            if (value is List<long>)
                val = string.Join(",", (value as List<long>));
            else if (value is List<string>)
                val = string.Join(",", (value as List<string>));
            else if (value is List<int>)
                val = string.Join(",", (value as List<int>));
            else if (value is DateTime)
                val = ((long)((DateTime)value - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds).ToString();
            else if (value is List<queue>)
                val = string.Join(",", (value as List<queue>));
            else if (value is List<season>)
                val = string.Join(",", (value as List<season>));
            else
                val = value.ToString();

            apiurl.Url = apiurl.Url.Replace(string.Format("{{{0}}}", key.ToString()), val);
            //apiurl.Parameters.Add(key.ToString(), value);
        }

        public static void RemoveParam<T>(this RiotApiCaller<T> apiurl, param key) where T : class
        {
            string find = string.Format("&{0}={{{0}}}", key.ToString());
            apiurl.Url = apiurl.Url.Replace(find, "");
        }

        public static void CreateRequest<T>(this RiotApiCaller<T> apiurl) where T : class
        {
            string Json = string.Empty;
            apiurl.Url = apiurl.Url.Replace("{api_key}", apikey.Key);// <==  api key
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl.Url);
            request.Method = "GET";
            request.UserAgent = "RiotCaller";
            request.Headers.Add("Accept-Language", "en-US");
            request.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8");
            request.ContentType = "application/json";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream, System.Text.Encoding.UTF8);
                    Json = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                }
                if (apiurl.Suffix == suffix.statsRanked || apiurl.Suffix == suffix.statsSummary || apiurl.Suffix == suffix.matchlist || apiurl.Suffix == suffix.matchdetail)
                {
                    apiurl.Result.Add(JsonConvert.DeserializeObject<T>(Json));
                }
                else
                {
                    apiurl.Result = JsonConvert.DeserializeObject<Dictionary<string, T>>(Json).Values.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}