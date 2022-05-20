using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsWiki.Wiki
{
    public class User
    {
        public string userID { get; set; }
        public string userPwd { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }

        public User(string userID, string userPwd, string userName, string userEmail) 
        {
            this.userID = userID;
            this.userPwd = userPwd;
            this.userName = userName;
            this.userEmail = userEmail;
        }

        public override string ToString()
        {
            return "(\'" + userID + "\'," +
                "\'" + userPwd + "\'," +
                "\'" + userName + "\'," +
                "\'" + userEmail + "\')";
        }
    }
}
