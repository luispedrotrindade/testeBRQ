using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace testeBRQ.Controllers
{
    public class ClienteController : Controller
    {
        [RoutePrefix("api/fiscalizacao")]
        public IActionResult Index()
        {
            return View();
        }
    }
}