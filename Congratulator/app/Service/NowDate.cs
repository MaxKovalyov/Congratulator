using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Service
{
    public static class NowDate
    {
        public static int nowDay { get; set; }

        public static int nowMonth { get; set; }

        public static int nowYear { get; set; }

        static NowDate()
        {
            string date = DateTime.Now.ToShortDateString();
            nowDay = Convert.ToInt32($"{date[0]}{date[1]}");
            nowMonth = Convert.ToInt32($"{date[3]}{date[4]}");
            nowYear = Convert.ToInt32($"{date[6]}{date[7]}{date[8]}{date[9]}");
        }

    }
}
