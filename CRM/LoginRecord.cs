using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class LoginRecord
    {
        public string userId { get; set; }
        public string userName { get; set; }
        public string loginTime { get; set; }
        public LoginRecord(int userId, string userName, string loginTime)
        {
            this.userId = Convert.ToString(userId);
            this.userName = userName;
            this.loginTime = loginTime;
        }
    }
}
