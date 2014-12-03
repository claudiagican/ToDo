using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo
{
    public static class Utils
    {

        public static string TimeFromNow(DateTime dt)
        {
            TimeSpan ts = DateTime.Now - dt;

            if (ts.TotalDays < 1)
            {
                if (DateTime.Now.Day == dt.Day)
                    return "Today";
                else
                    return "Yesterday";
            }

            if (ts.TotalDays < 2)
                return "Yesterday";

            if (ts.TotalDays < 7)
                return string.Format("{0} days ago", ts.Days);

            if (ts.Days < 14)
                return string.Format("{0} week ago", ts.Days / 7);

            if (ts.Days < 30)
                return string.Format("{0} weeks ago", ts.Days / 7);

            if (ts.Days < 365)
                return string.Format("{0} months ago", ts.Days / 30);

            return string.Format("{0} years ago", ts.Days / 365);
        }
    }
}