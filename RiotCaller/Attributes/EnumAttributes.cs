using System;

namespace RiotCaller.Attributes
{
    /// <summary>
    /// api url version sets 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        private readonly double value;

        public VersionAttribute(double _value)
        {
            this.value = _value;
        }

        public double Description { get { return value; } }

        public override string ToString()
        {
            return Description.ToString();
        }
    }
}