using System;
using Electronica.BL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace Electronica.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var ListadeProductos = productosBL.ObtenerProductosActivos();

            ViewBag.adminWebsiteUrl 
                = ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(ListadeProductos);
        }
    }
}