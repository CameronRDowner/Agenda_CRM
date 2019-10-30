using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class TimeConversion
    {
        private TimeZoneInfo timeZoneInfo;
        public string getUserTimeZoneOffset()
        {
            timeZoneInfo = TimeZoneInfo.Local;
            return timeZoneInfo.BaseUtcOffset.ToString().Remove(3, 3);
        }
        public string getDataBaseTimeZoneOffset()
        {
            return "+00:00";
        }
    }
}
