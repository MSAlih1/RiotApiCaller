using RiotCaller.Enums;
using System;

namespace RiotCaller.Attributes
{
    /// <summary>
    /// checks if static or non-static 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class IsStaticAttribute : Attribute
    {
        private readonly apiType value;

        public IsStaticAttribute(bool _isStatic)
        {
            this.value = _isStatic == true ? apiType.Static : apiType.nonStatic;
        }

        public apiType isStatic { get { return value; } }

        public override string ToString()
        {
            return isStatic.ToString();
        }
    }
}