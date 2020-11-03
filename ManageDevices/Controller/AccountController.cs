using ManageDevices.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageDevices.Controller
{
    public class AccountController
    {
        private Database db = Database.instance;
        public static AccountController controller = new AccountController();
        private AccountController() { }

        public string login(string username,string password)
        {
            var comm = db.getCommStored("_Login");
            comm.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            comm.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            return db.Reader();

        }
    }
}