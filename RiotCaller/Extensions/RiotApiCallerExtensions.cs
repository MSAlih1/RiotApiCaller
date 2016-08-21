using Newtonsoft.Json;
using RiotCaller.Api.Cache;
using RiotCaller.Api.Service;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace RiotCaller
{
    /// <summary>
    /// url parameters, api key includes , begin request 
    /// </summary>
    public static class RiotApiCallerExtensions
    {
        /// <summary> Example => AddParam(ParamTypes.summonerIds, new List<long>() { 466244, 457724
        /// }); Example => AddParam(ParamTypes.region, "tr"); </summary>
        public static void AddParam<T>(this RiotApiCaller<T> rac, param key, object value) where T : class
        {
            string val = "";
            if (value is List<long>)
                val = string.Join(",", (value as List<long>));
            else if (value is List<string>)
                val = string.Join(",", (value as List<string>));
            else if (value is List<int>)
                val = string.Join(",", (value as List<int>));
            else if (value is DateTime)
                val = ((long)((DateTime)value - new DateTime(1970, 1, 1, 0, 0, 0, 0))
                    .TotalMilliseconds).ToString();
            else if (value is List<queue>)
                val = string.Join(",", (value as List<queue>));
            else if (value is List<season>)
                val = string.Join(",", (value as List<season>));
            else
                val = value.ToString();

            rac.Url = rac.Url.Replace(string.Format("{{{0}}}", key.ToString()), val);
            rac.cacheBuild.Add(value.ToString().ToLower());
        }

        public static void RemoveParam<T>(this RiotApiCaller<T> rac, param key) where T : class
        {
            string find = string.Format("&{0}={{{0}}}", key.ToString());
            rac.Url = rac.Url.Replace(find, "");
        }

        public static cacheObject<T> CreateRequest<T>(this RiotApiCaller<T> rac, TimeSpan? expiryTime) where T : class
        {
            CreateRequest(rac);
            if (expiryTime != null)
                return new cacheObject<T>(rac.cacheBuild, rac.Result.FirstOrDefault(), expiryTime.Value);
            else
                return null;
        }

        public static void CreateRequest<T>(this RiotApiCaller<T> rac) where T : class
        {
            string Json = string.Empty;
            if (rac.Suffix != suffix.status)
            {
                if (!rac.Url.EndsWith("&") && !rac.Url.EndsWith("?"))
                    rac.Url += "&";
                rac.Url += string.Format("api_key={0}", ApiService.ApiKey);//api key joining
            }
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, rac.Url);
                request.Headers.Add("UserAgent", "RiotCaller");
                request.Headers.Add("Accept-Language", "en-US");
                request.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8");
                HttpClient httpClient = new HttpClient();
                using (HttpResponseMessage response = httpClient.GetAsync(request.RequestUri).Result)
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        if ((int)response.StatusCode == 404)
                        {
                            return;//not found
                        }
                        else if ((int)response.StatusCode == 429)
                        {
                            return;//limit exceeded
                        }
                        else
                        {
                            throw new Exception("ERROR: " + response.StatusCode.ToString());
                        }
                    }

                    using (HttpContent content = response.Content)
                    {
                        Json = content.ReadAsStringAsync().Result;
                    }
                }
                try
                {
                    rac.Result = JsonConvert.DeserializeObject<Dictionary<string, T>>(Json).Values.ToList();//method 1
                }
                catch (Exception ex)
                {
                    if (ex.Source == "Newtonsoft.Json")
                        rac.Result.Add(JsonConvert.DeserializeObject<T>(Json));//method 2
                }
            }
            catch (Exception e)
            {
                if (e.Source == "Newtonsoft.Json")
                    rac.ResultStruct = int.Parse(Json);//method 3 //only for ChampionScore() results, other way somethings may mistake
                else
                {
                    throw e;
                }
            }
        }
    }
}