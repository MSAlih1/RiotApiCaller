using System;

namespace RiotCaller.Attributes
{
    /// <summary>
    /// for enum string value 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ValueAttribute : Attribute
    {
        private readonly string value;

        public ValueAttribute(string _value)
        {
            this.value = _value;
        }

        public string Description { get { return value; } }

        public override string ToString()
        {
            return Description;
        }
    }
}