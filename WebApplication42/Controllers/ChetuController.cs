using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.MobileControls;
using WebApplication42.Models;

namespace WebApplication42.Controllers
{
    public class chetucontroller : controller
    {
        private readonly anoopentities dbcontext;

        public chetucontroller()
        {
            dbcontext = new anoopentities();
        }
        // get: chetu
        public actionresult index()
        {
            //string message = "this is .net batch";
            //viewbag.msg = message;
            /*viewbag.employees = new list<string>()
            {
                "naman","ashish","lavi","rakhi"
            };   
            string message = "this is mvc project";
            viewdata["msg"] = message;    
            viewdata["employees"] = new list<string>()
            { "ashu","mayank","akansha"};  */
            //class1 emp = new class1()
            //{ id = 1011, name = "ankit", sal = 12000 };

            //  list<employee> employees = dbcontext.employees.tolist();


            //    return view(employees);
            //}

        }
       
    }
}