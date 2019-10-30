using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class MonthRecord
    {
        public string Month { get; set; }
        public int NumberOfTypes { get; set; }
        public MonthRecord(string month, int NumberOfTypes)
        {
            this.Month = month;
            this.NumberOfTypes = NumberOfTypes;
        }
    }
}
