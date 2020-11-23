using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageDevices.Model;
using System.Data;

namespace ManageDevices.Controller
{
    public class QLTB_Controller
    {
        public static QLTB_Controller ins = new QLTB_Controller();
        private Database db = Database.instance;
        private QLTB_Controller() { }
        public string searchWithCode(string maql)
        {
            var comm = db.getCommStored("getTB_With_Code");
            comm.Parameters.Add("@maql", SqlDbType.VarChar).Value = maql;
            return db.Reader();
        }
    }
}