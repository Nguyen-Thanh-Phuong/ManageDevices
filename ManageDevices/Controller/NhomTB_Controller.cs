using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageDevices.Model;
using System.Data;

namespace ManageDevices.Controller
{
    public class NhomTB_Controller
    {
        private Database db = Database.instance;
        public static NhomTB_Controller ins = new NhomTB_Controller();
        private NhomTB_Controller() { }

        public string insert(string manhomTB, string tennhomTB,string dvt,int loai,string makt)
        {
            var comm = db.getCommStored("insertDM_NhomTB");
            comm.Parameters.Add("@manhomTB", SqlDbType.VarChar).Value = manhomTB;
            comm.Parameters.Add("@ten_nhomtbi", SqlDbType.NVarChar).Value = tennhomTB;
            comm.Parameters.Add("@dvt", SqlDbType.NVarChar).Value = dvt;
            comm.Parameters.Add("@loai", SqlDbType.Int).Value = loai;
            comm.Parameters.Add("@makt", SqlDbType.VarChar).Value = makt;

            return db.Reader();
        }
        public string getAll()
        {
            var comm = db.getCommStored("DM_NhomTB_SelectAll");
            return db.Reader();
        }
        public string update(string manhomTB, string tennhomTB, string dvt, int loai, string makt)
        {
            var comm = db.getCommStored("DM_NhomDT_Update");
            comm.Parameters.Add("@manhomTB", SqlDbType.VarChar).Value = manhomTB;
            comm.Parameters.Add("@ten_nhomtbi", SqlDbType.NVarChar).Value = tennhomTB;
            comm.Parameters.Add("@dvt", SqlDbType.NVarChar).Value = dvt;
            comm.Parameters.Add("@loai", SqlDbType.Int).Value = loai;
            comm.Parameters.Add("@makt", SqlDbType.VarChar).Value = makt;
            return db.Reader();
        }
        public string delete(string manhomTB)
        {
            var comm = db.getCommStored("DM_NhomTB_delete");
            comm.Parameters.Add("@manhom", SqlDbType.VarChar).Value = manhomTB;
            return db.Reader();
        }
        public string getWithCode(string manhomTB)
        {
            var comm = db.getCommStored("DM_NhomTB_GetWithCode");
            comm.Parameters.Add("@manhom", SqlDbType.VarChar).Value = manhomTB;
            return db.Reader();
        }
    }
}