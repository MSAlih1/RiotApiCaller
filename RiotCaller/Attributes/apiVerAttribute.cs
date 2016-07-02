using RiotCaller.Enums;
using System;

namespace RiotCaller.Attributes
{
    /// <summary>
    /// Instead of overload methods 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class apiVerAttribute : Attribute
    {
        private readonly apiVer value;

        public apiVerAttribute(apiVer _apigroup)
        {
            this.value = _apigroup;
        }

        public apiVer isStatic { get { return value; } }

        public override string ToString()
        {
            return isStatic.ToString();//for language-strings;
        }
    }
}