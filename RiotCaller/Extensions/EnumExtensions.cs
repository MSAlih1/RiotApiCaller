using System;
using System.Linq;
using System.Reflection;
using static RiotCaller.EnumAttributes;

namespace RiotCaller
{
    public static class EnumsHelper
    {
        public static Attribute GetValue(this Enum enumVal)
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());
            return v.GetCustomAttribute<ValueAttribute>();
        }

        public static ApiGroup GetApiGrop(this Suffix enumVal)
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());
            return v.GetCustomAttribute<ApiGropAttribute>().isStatic;
        }

        public static ApiType GetApiType(this Suffix enumVal)
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());
            return v.GetCustomAttribute<ApiTypeAttribute>().ApiType;
        }

        public static string GetVersion(this ApiGroup enumVal)
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());
            string version = v.GetCustomAttribute<VersionAttribute>().Description.ToString().Replace(",", ".");
            return version;
        }
    }
}