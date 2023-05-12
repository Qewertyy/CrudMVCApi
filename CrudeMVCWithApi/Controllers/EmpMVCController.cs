using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudeMVCWithApi.Models;
using System.Net.Http;

namespace CrudMVCWithApi.Controllers
{
    public class EmpMVCController : Controller
    {
        // GET: EmpMVC
        public ActionResult Emp()
        {
            HttpClient SysClient = new HttpClient();
            SysClient.BaseAddress = new Uri("api/");
            return View();
        }
    }
}