using Cibertec.Repositories.Dapper.Northwind;
using Cibertec.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cibertec.Mvc.Controllers
{
    public class OrderController : Controller
    {

        private readonly IUnitOfWork _unit;
        public OrderController()
        {
            _unit = new NorthwindUnitOfWork(ConfigurationManager
                                            .ConnectionStrings["NorthwindConnection"].ToString());
        }
        public ActionResult Index()
        {
            return View(_unit.Orders.GetList());
        }
    }
}