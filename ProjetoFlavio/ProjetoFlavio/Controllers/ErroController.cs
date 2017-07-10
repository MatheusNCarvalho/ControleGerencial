using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFlavio.Controllers
{
    public class ErroController : Controller
    {
        // GET: Erro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NaoEncontrado()
        {
            return View();
        }
    }
}