using ManageDevices.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ManageDevices
{
    /// <summary>
    /// Summary description for Services
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Services : System.Web.Services.WebService
    {
        AccountController accountController = AccountController.controller;
        private NhomTB_Controller nhomTB = NhomTB_Controller.ins;
        private NhomDT_Controller nhomDT = NhomDT_Controller.ins;
        private QLTB_Controller qltb = QLTB_Controller.ins;
        private CTTB_Controller cttb = CTTB_Controller.ins;
        [WebMethod]
        public string login(string username, string pass)
        {
            return accountController.login(username, pass);
        }
        /*
         * Group Object
         */
        [WebMethod]
        public string DM_NhomDT_insert(string manhomDT, string tennhomDT)
        {
            return nhomDT.insert(manhomDT, tennhomDT);
        }
        [WebMethod]
        public string DM_NhomDT_update(string manhomDT,string tennhomDT)
        {
            return nhomDT.update(manhomDT, tennhomDT);
        }
        [WebMethod]
        public string DM_NhomDT_getAll()
        {
            return nhomDT.getAll();
        }
        [WebMethod]
        public string DM_NhomDT_delete(string manhomDT)
        {
            return nhomDT.delete(manhomDT);
        }
        [WebMethod]
        public string DM_NhomDT_getWithCode(string manhomDT)
        {
            return nhomDT.getWithCode(manhomDT);
        }
        /*
         * Group Devices
         */
        [WebMethod]
        public string DM_NhomTB_insert(string manhomTB,string ten,string dvt,int loai,string makt)
        {
            return nhomTB.insert(manhomTB, ten, dvt, loai,makt);
        }
        [WebMethod]
        public string DM_NhomTB_getAll()
        {
            return nhomTB.getAll();
        }
        [WebMethod]
        public string DM_NhomTB_delete(string manhomTB)
        {
            return nhomTB.delete(manhomTB);
        }
        [WebMethod]
        public string DM_nhomTB_update(string manhomTB, string ten, string dvt, int loai, string makt)
        {
            return nhomTB.insert(manhomTB, ten, dvt, loai, makt);
        }
        [WebMethod]
        public string DM_NhomTB_getWithCode(string manhomTB)
        {
            return nhomTB.getWithCode(manhomTB);
        }
        /*
         * QLTB
         */
        [WebMethod]
        public string search_QLTB_With_maql(string maql)
        {
            return qltb.searchWithCode(maql);
        }
        /*
         * CTTB
         */
        [WebMethod]
        public string search_CTTB_With_maql(string maql)
        {
            return cttb.searchWithCode(maql);
        }
    }

}
