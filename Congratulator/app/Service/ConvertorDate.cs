using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Service
{
    public static class ConvertorDate
    {
        public static string convertToDateString(int day, char divider, int month)
        {
            string dayStr, monthStr;
            dayStr = (day < 10) ? "0" + day : Convert.ToString(day);
            monthStr = (month < 10) ? "0" + month : Convert.ToString(month);
            return $"{dayStr}{divider}{monthStr}";
        }
    }
}
