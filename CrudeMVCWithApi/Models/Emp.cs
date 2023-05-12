using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudeMVCWithApi.Models
{
    public class Emp
    {
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public decimal EmpSal { get; set; }

        public string Gender { get; set; }
    }
}