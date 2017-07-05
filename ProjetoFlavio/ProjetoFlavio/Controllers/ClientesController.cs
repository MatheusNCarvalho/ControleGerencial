using ProjetoFlavio.DAO;
using ProjetoFlavio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFlavio.Controllers
{
    


    public class ClientesController : Controller
    {
        private readonly ClienteDao _clienteDao = new ClienteDao();
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        [Route("clientes/novo", Name ="NovosClientes")]
        public ActionResult Novo()
        {
            return View();
            
        }

        public ActionResult Salvar(Cliente cliente)
        {
            return RedirectToAction("Index");
        }

        [Route("clientes", Name ="ListarClientes")]
        public ActionResult Listar()
        {
            var clientes = _clienteDao.Lista();
            return View(clientes);
        }
    }
}