using CrudeMVCWithApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace CrudeMVCWithApi.Controllers
{
    public class EmpApiController : ApiController
    {
        [Route("api/Emp/GetEmp/{id}")]
        [HttpGet]
        public IEnumerable<Emp> GetEmp(int id)
        {
            return new DataLayer().GetEmp(id);
        }

        [Route("api/Emp/AddEmp/")]
        [HttpPost]
        public void AddEmp(Emp emp)
        {
            new DataLayer().AddEmp(emp);
        }

        [Route("api/Emp/GetEditEmp/{id}")]
        [HttpGet]
        public Emp GetEditEmp(int id)
        {
            return new DataLayer().GetEditEmp(id);
        }

        [Route("api/Emp/UpdateEmp/{emp}")]
        [HttpPost]
        public void UpdateEmp(Emp emp)
        {
            new DataLayer().UpdateEmp(emp);
        }

        [Route("api/Emp/GetAllEmp/")]
        [HttpGet]
        public IEnumerable<Emp> GetAllEmployess(Emp emp)
        {
            return new DataLayer().GetAllEmployees(emp);
        }

        [Route("api/Emp/DelEmp/{id}")]
        [HttpDelete]
        public void DelEmp(int id)
        {
            new DataLayer().DelEmp(id);
        }
    }
}
