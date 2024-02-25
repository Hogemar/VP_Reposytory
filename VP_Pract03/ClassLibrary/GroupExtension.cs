using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class GroupExtension
    {
        public static uint StudentsNumber(this Group group)
        {
            return Convert.ToUInt32(Regex.Matches(group.GetInfo(), "Зачётная книжка:").Count);
        }
    }
}
