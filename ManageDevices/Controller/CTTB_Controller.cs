using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageDevices.Model;
using System.Data;

namespace ManageDevices.Controller
{
    public class CTTB_Controller
    {
        public static CTTB_Controller ins = new CTTB_Controller();
        private Database db = Database.instance;
        private CTTB_Controller() { }
        public string searchWithCode(string maql)
        {
            var comm = db.getCommStored("search_CTTBWithMaql");
            comm.Parameters.Add("@maql", SqlDbType.VarChar).Value = maql;
            return db.Reader();
        }
    }
}