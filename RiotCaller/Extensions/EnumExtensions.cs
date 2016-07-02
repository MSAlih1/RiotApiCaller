using RiotCaller.Attributes;
using RiotCaller.Enums;
using System;
using System.Linq;
using System.Reflection;

namespace RiotCaller
{
    public static class EnumsHelper
    {
        public static string ToString2(this apiVer enumVal)
        {
            return enumVal.ToString().Replace("_", "-");
        }

        public static apiVer GetApiGroup(this suffix enumVal)
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());
            apiVer y = v.GetCustomAttribute<apiVerAttribute>().isStatic;
            return y;
        }

        public static apiType GetApiType(this suffix enumVal)
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());
            return v.GetCustomAttribute<ApiTypeAttribute>().ApiType;
        }

        public static Attribute GetValue(this Enum enumVal)
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());
            return v.GetCustomAttribute<ValueAttribute>();
        }

        public static string GetVersion(this apiVer enumVal)
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());
            string version = v.GetCustomAttribute<VersionAttribute>().Description.ToString("F1").Replace(",", ".");
            return version;
        }

        public static Platform ToPlatform(this region enumVal)
        {
            switch (enumVal)
            {
                case region.tr:
                    return Platform.TR1;

                case region.ru:
                    return Platform.RU;

                case region.las:
                    return Platform.LA2;

                case region.lan:
                    return Platform.LA1;

                case region.oce:
                    return Platform.OC1;

                case region.kr:
                    return Platform.KR;

                case region.na:
                    return Platform.NA1;

                case region.euw:
                    return Platform.EUW1;

                case region.br:
                    return Platform.BR1;

                case region.eune:
                    return Platform.EUN1;

                default:
                    return Platform.TR1;
            }
        }

        public static region ToRegion(this Platform enumVal)
        {
            switch (enumVal)
            {
                case Platform.TR1:
                    return region.tr;

                case Platform.NA1:
                    return region.na;

                case Platform.BR1:
                    return region.br;

                case Platform.RU:
                    return region.ru;

                case Platform.EUW1:
                    return region.euw;

                case Platform.KR:
                    return region.kr;

                case Platform.LA1:
                    return region.lan;

                case Platform.LA2:
                    return region.las;

                case Platform.OC1:
                    return region.oce;

                case Platform.EUN1:
                    return region.eune;

                default:
                    return region.tr;
            }
        }
    }
}