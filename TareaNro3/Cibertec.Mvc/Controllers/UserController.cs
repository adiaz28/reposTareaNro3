﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cibertec.Repositories.Dapper.Northwind;
using Cibertec.UnitOfWork;

namespace Cibertec.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unit;
        public UserController()
        {
            _unit = new NorthwindUnitOfWork(ConfigurationManager
                                            .ConnectionStrings["NorthwindConnection"].ToString());
        }
        public ActionResult Index()
        {
            return View(_unit.Users.GetList());
        }
    }
}