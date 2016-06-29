using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;

namespace RiotCaller
{
    /// <summary>
    /// url parameters, api key includes , begin request 
    /// </summary>
    public static class ApiUrlExtensions
    {
        /// <summary> Example => AddParam(ParamTypes.summonerIds, new List<long>() { 466244, 457724
        /// }); Example => AddParam(ParamTypes.region, "tr"); </summary>
        public static void AddParam<T>(this ApiUrl<T> apiurl, paramType key, object value) where T : class
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

            apiurl.Url = apiurl.Url.Replace(string.Format("{{{0}}}", key.ToString()), val);
            apiurl.Parameters.Add(key.ToString(), value);
        }

        public static void CreateRequest<T>(this ApiUrl<T> apiurl) where T : class
        {
            string JsonText = string.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl.Url);
            request.Method = "GET";
            request.UserAgent = "RiotCaller";
            request.Headers.Add("Accept-Language", "en-US");
            request.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream, System.Text.Encoding.UTF8);
                JsonText = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            apiurl.ResultData = JsonConvert.DeserializeObject(JsonText);
        }
    }
}