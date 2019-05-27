using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cibertec.Repositories.Dapper.Northwind;
using Cibertec.UnitOfWork;

namespace Cibertec.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unit;
        public ProductController()
        {
            _unit = new NorthwindUnitOfWork(ConfigurationManager
                                            .ConnectionStrings["NorthwindConnection"].ToString());
        }
        public ActionResult Index()
        {
            return View(_unit.Products.GetList());
        }
    }
}