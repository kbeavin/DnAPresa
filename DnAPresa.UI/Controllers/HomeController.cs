using DnAPresa.UI.Models;
using DnAScreener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnAPresa.UI.Controllers
{
    public class HomeController : Controller
    {
        LoginModels loginModel = new LoginModels();

        #region Index
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(LoginModels mData)
        {
            JsonResult json = new JsonResult { Data = mData,  };

            try
            {
                loginModel.Username = mData.Username;
                loginModel.Password = mData.Password;

                json.Data = mData;
            }
            catch (Exception ex)
            {
                return new JsonResult { Data = "fail" };
            }

            return json;
        }

        #endregion

        #region Driver

        public ActionResult Driver(TabModels mData)
        {
            TabModels viewModel = new TabModels();

            try
            {
                DataMgr myDataMgr = new DataMgr("hi", "hi");

                var myData = myDataMgr.getDrivers();

                viewModel.TotalActiveDrivers = myData.Rows.Count;
            }
            catch (Exception ex)
            {
                return View(viewModel);
            }

            return View(viewModel);
        }

        #endregion

        #region ExpressOffice

        public ActionResult ExpressOffice()
        {
            TabModels viewModel = new TabModels();

            try
            {
                DataMgr myDataMgr = new DataMgr("hi", "hi");

                var myData = myDataMgr.getCEXPOffice();

                viewModel.TotalActiveDrivers = myData.Rows.Count;
            }
            catch (Exception ex)
            {
                return View(viewModel);
            }

            return View(viewModel);
        }

        #endregion

        #region ExpressWarehouse

        public ActionResult ExpressWarehouse()
        {
            TabModels viewModel = new TabModels();

            try
            {
                DataMgr myDataMgr = new DataMgr("hi", "hi");

                var myData = myDataMgr.getCEXPWarehouse();

                viewModel.TotalActiveDrivers = myData.Rows.Count;
            }
            catch (Exception ex)
            {
                return View(viewModel);
            }

            return View(viewModel);
        }

        #endregion

        #region Logistics

        public ActionResult Logistics()
        {
            TabModels viewModel = new TabModels();

            try
            {
                DataMgr myDataMgr = new DataMgr("hi", "hi");

                var myData = myDataMgr.getCLL();

                viewModel.TotalActiveDrivers = myData.Rows.Count;
            }
            catch (Exception ex)
            {
                return View(viewModel);
            }

            return View(viewModel);
        }

        #endregion

        #region Duke

        public ActionResult Duke()
        {
            TabModels viewModel = new TabModels();

            try
            {
                DataMgr myDataMgr = new DataMgr("hi", "hi");

                var myData = myDataMgr.getDukel();

                viewModel.TotalActiveDrivers = myData.Rows.Count;
            }
            catch (Exception ex)
            {
                return View(viewModel);
            }

            return View(viewModel);
        }

        #endregion

        #region Canton

        public ActionResult Canton()
        {
            TabModels viewModel = new TabModels();

            try
            {
                DataMgr myDataMgr = new DataMgr("hi", "hi");

                var myData = myDataMgr.getCantons();

                viewModel.TotalActiveDrivers = myData.Rows.Count;
            }
            catch (Exception ex)
            {
                return View(viewModel);
            }

            return View(viewModel);
        }

        #endregion

        #region Helpers

        public void SetUserCredentials(string UName, string pwd)
        {
            try
            {
                loginModel.Username = UName;
                loginModel.Password = pwd;
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
    }
}