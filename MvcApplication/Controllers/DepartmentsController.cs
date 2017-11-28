using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.OracleClient;
using ClassLibrary;
using MvcApplication.Models;
using System.Web.Optimization;

namespace MvcApplication.Controllers
{
    public class DepartmentsController : Controller
    {
        //
        // GET: /Departments/

        public ActionResult Index()
        {
            var cmd = new OracleCommand();
            cmd.CommandText = "select global_dept_name from hart_global_depts_mv";
            var set = Database.GetData(cmd, "dbdev2.hscnet.hsc.usf.edu", "1522", "dbdev", "hsc", "graham_hill");

            List<Department> departments = new List<Department>();
            foreach(DataRow row in set.Tables[0].Rows)
                departments.Add(new Department(){GlobalDeptName=row["global_dept_name"].ToString()});


            return View("DepartmentsView", departments);
        }

    }
}
