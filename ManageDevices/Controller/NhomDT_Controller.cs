using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageDevices.Model;
using System.Data;

namespace ManageDevices.Controller
{
    public class NhomDT_Controller
    {
        private Database db = Database.instance;
        public static NhomDT_Controller ins = new NhomDT_Controller();
        private NhomDT_Controller() { }

        public string insert(string manhomDT,string tennhomDT)
        {
            var comm = db.getCommStored("insertNhomDT");
            comm.Parameters.Add("@maNhomDT", SqlDbType.NChar).Value = manhomDT;
            comm.Parameters.Add("@tenNhomDT", SqlDbType.NVarChar).Value = tennhomDT;
            return db.Reader();
        }
        public string getAll()
        {
            var comm = db.getCommStored("DM_NhomDT_SelectAll");
            return db.Reader();
        }
        public string update(string manhomDT, string tennhomDT)
        {
            var comm = db.getCommStored("DM_NhomDT_Update");
            comm.Parameters.Add("@manhom", SqlDbType.NChar).Value = manhomDT;
            comm.Parameters.Add("@tennhom", SqlDbType.NVarChar).Value = tennhomDT;
            return db.Reader();
        }
        public string delete(string manhomDT)
        {
            var comm = db.getCommStored("DM_NhomDT_Update");
            comm.Parameters.Add("@manhomDT", SqlDbType.NChar).Value = manhomDT;
            return db.Reader();
        }
        public string getWithCode(string manhomDT)
        {
            var comm = db.getCommStored("DM_NhomDT_SelectWithCode");
            comm.Parameters.Add("@manhomDT", SqlDbType.NChar).Value = manhomDT;
            return db.Reader();
        }
    }
}