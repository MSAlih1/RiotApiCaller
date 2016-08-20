using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller
{
    public static class TypeExtensions
    {
        public static string ToCacheParam(this Type typeVal)
        {
            string val = "";
            TypeInfo findProperties = typeVal.GetTypeInfo();
            foreach (MemberInfo item in findProperties.DeclaredMembers)
            {
                string MemberType = item.ToString();
                if (MemberType.StartsWith("System.Collections.Generic.List`"))
                {
                    val = string.Format("{0}[{1}]", typeVal.GetTypeInfo().BaseType.Name, typeVal.GetTypeInfo().Name);
                    break;
                }
                else if (MemberType.StartsWith("System.Collections.Generic.Dictionary`"))
                {
                    val = string.Format("{0}<{1}>", typeVal.GetTypeInfo().BaseType.Name, typeVal.GetTypeInfo().Name);
                    break;
                }
            }
            if (val == "")
            {
                val = typeVal.Name;
                //throw new Exception("undefined property type for reflection", new Exception("RiotCaller.TypeExtensions.ToCacheParam=" + typeVal.ToString()));
            }
            return val;
        }
    }
}
