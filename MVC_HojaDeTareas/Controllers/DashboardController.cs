﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HojaDeTareas.Controllers
{
    public class DashboardController : BaseController
    {
        // GET: Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }
      
    }
 
}