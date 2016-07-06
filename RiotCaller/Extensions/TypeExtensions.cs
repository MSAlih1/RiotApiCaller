using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller
{
    public static class TypeExtensions
    {
        public static string ToCacheParam(this Type typeVal)
        {
            string val = "";
            if (typeVal.Name.StartsWith("List`"))//"List`1" (it is list)
            {
                val = string.Format("{0}[{1}]", typeVal.Name, typeVal.GetProperties()[2].PropertyType);
            }
            else
                val = string.Format("{0}.{1}", typeVal.BaseType.Name, typeVal.Name);

            return val;
        }
    }
}
