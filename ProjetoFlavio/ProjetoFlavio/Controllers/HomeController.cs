using ProjetoFlavio.DAO;
using ProjetoFlavio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFlavio.Controllers
{
    public class HomeController : Controller
    {
        private  readonly ClienteDao _clienteDao = new ClienteDao();
        private readonly ClienteEnderecoDao _clienteEnderecoDao = new ClienteEnderecoDao();

        [Route("home", Name ="Home")]
        // GET: Home
        public ActionResult Index()
        {
            /*Cliente cliente = new Cliente()
            {
                Nome = "Teste",
                Celular ="11111",
                CpfCnpj = "55555",
                Email = "matheus"                
            };
            _clienteDao.Salva(cliente);
            ClienteEndereco clienteEndereco = new ClienteEndereco()
            {
                Bairro = "jardim",
                Cidade = "Morrinhos",
                ClientesId = cliente.ClienteId
            };
            _clienteEnderecoDao.Salva(clienteEndereco);*/
            return View();
        }
    }
}