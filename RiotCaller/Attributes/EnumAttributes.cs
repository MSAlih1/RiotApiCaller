using System;

namespace RiotCaller
{
    public class EnumAttributes
    {
        /// <summary>
        /// Instead of overload methods 
        /// </summary>
        [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
        public class ApiGropAttribute : Attribute
        {
            private readonly apiGroup value;
            public ApiGropAttribute(apiGroup _apigroup)
            {
                this.value = _apigroup;
            }

            public apiGroup isStatic { get { return value; } }
            public override string ToString()
            {
                return isStatic.ToString();
            }
        }

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
}