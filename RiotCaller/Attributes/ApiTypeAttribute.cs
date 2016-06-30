using RiotCaller.Enums;
using System;

namespace RiotCaller.Attributes
{
    /// <summary>
    /// static and non-static api urls 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ApiTypeAttribute : Attribute
    {
        private readonly apiType value;

        public ApiTypeAttribute(apiType _apitype)
        {
            this.value = _apitype;
        }

        public apiType ApiType { get { return value; } }

        public override string ToString()
        {
            return ApiType.ToString();
        }
    }
}