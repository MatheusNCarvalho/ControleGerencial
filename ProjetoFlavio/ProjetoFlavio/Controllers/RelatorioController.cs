
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ProjetoFlavio.DAO;
using System.Configuration;

namespace ProjetoFlavio.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly ClienteDao _clienteDao = new ClienteDao();

        // GET: Relatorio
        
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult GeraLaudo()
        {

            ViewBag.ListaClientes = _clienteDao.Lista();
            return View();
        }
        
    }
}