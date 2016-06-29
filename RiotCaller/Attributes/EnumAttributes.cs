using System;

namespace RiotCaller
{
    public class EnumAttributes
    {
        /// <summary>
        /// for enum string value 
        /// </summary>
        [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
        public class ValueAttribute : Attribute
        {
            private readonly string value;
            public string Description { get { return value; } }

            public ValueAttribute(string _value)
            {
                this.value = _value;
            }

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
            public double Description { get { return value; } }

            public VersionAttribute(double _value)
            {
                this.value = _value;
            }

            public override string ToString()
            {
                return Description.ToString();
            }
        }

        /// <summary>
        /// checks if static or non-static 
        /// </summary>
        [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
        public class IsStaticAttribute : Attribute
        {
            private readonly ApiType value;
            public ApiType isStatic { get { return value; } }

            public IsStaticAttribute(bool _isStatic)
            {
                this.value = _isStatic == true ? ApiType.Static : ApiType.nonStatic;
            }

            public override string ToString()
            {
                return isStatic.ToString();
            }
        }

        /// <summary>
        /// Instead of overload methods 
        /// </summary>
        [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
        public class ApiGropAttribute : Attribute
        {
            private readonly ApiGroup value;
            public ApiGroup isStatic { get { return value; } }

            public ApiGropAttribute(ApiGroup _apigroup)
            {
                this.value = _apigroup;
            }

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
            private readonly ApiType value;
            public ApiType ApiType { get { return value; } }

            public ApiTypeAttribute(ApiType _apitype)
            {
                this.value = _apitype;
            }

            public override string ToString()
            {
                return ApiType.ToString();
            }
        }
    }
}