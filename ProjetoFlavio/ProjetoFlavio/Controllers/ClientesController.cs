using ProjetoFlavio.DAO;
using ProjetoFlavio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFlavio.Controllers
{


    [HandleError(View = "../Error")]
    public class ClientesController : Controller
    {
        private readonly ClienteDao _clienteDao = new ClienteDao();
        private readonly ClienteEnderecoDao _clienteEnderecoDao = new ClienteEnderecoDao();
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

        [HttpPost]
        [ValidateAntiForgeryToken]        
        public ActionResult Salvar(ViewModelClienteEndereco viewCadastrado)
        {
            try {
                //ClientesId = cliente.ClienteId
                if (ModelState.IsValid)
                {
                    _clienteDao.Salva(viewCadastrado.Clientes);
                    viewCadastrado.ClientesEnderecos.ClientesId = viewCadastrado.Clientes.ClienteId;
                    _clienteEnderecoDao.Salva(viewCadastrado.ClientesEnderecos);
                }

                return View("Novo", viewCadastrado);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Cadastrado", "Salvar"));
            }
            
        }

        [Route("clientes", Name ="ListarClientes")]
        public ActionResult Listar()
        {
            var clientes = _clienteDao.Lista();
            return View(clientes);
        }
    }
}