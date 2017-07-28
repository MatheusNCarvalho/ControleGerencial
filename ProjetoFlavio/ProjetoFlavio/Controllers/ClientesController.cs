using ProjetoFlavio.DAO;
using ProjetoFlavio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                
                if (ModelState.IsValid)
                {
                    _clienteDao.Salva(viewCadastrado.Clientes);
                    viewCadastrado.ClientesEnderecos.ClientesId = viewCadastrado.Clientes.ClienteId;
                    _clienteEnderecoDao.Salva(viewCadastrado.ClientesEnderecos);

                    return RedirectToAction("Listar");
                }
                else
                {
                    return View("Novo", viewCadastrado);
                }

                
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


        [Route("clientes/{id}", Name ="EditarClientes")]
        public ActionResult Editar(int id)
        {
          
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var retornoDaConsulta  = _clienteEnderecoDao.BuscaPorClienteEndereco(id);

            if(retornoDaConsulta == null)
            {
                return RedirectToAction("NaoEncontrado", "Erro");
            }
            else
            {
                ViewModelClienteEndereco viewModelClienteEndereco = new ViewModelClienteEndereco(_clienteEnderecoDao.BuscaPorClienteEndereco(id));
                return View("Editar", viewModelClienteEndereco);
            }           

        }

        [Route("Salvar",Name ="SalvarEditar")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarSalvar(ViewModelClienteEndereco viewCadastrado)
        {
            if (ModelState.IsValid)
            {
                
                _clienteDao.Atualiza(viewCadastrado.Clientes);
                 viewCadastrado.ClientesEnderecos.ClientesId = viewCadastrado.Clientes.ClienteId;
                _clienteEnderecoDao.Atualiza(viewCadastrado.ClientesEnderecos);

                return RedirectToAction("Listar");
            }
            else
            {
                return View("Editar", viewCadastrado);
            }

        }

        [Route("busca/{id}", Name ="busca")]
        public JsonResult BuscaCliente(int id)
        {
             var retornoPesquisa=   _clienteEnderecoDao.BuscaPorClienteEndereco(id);

            return Json(retornoPesquisa, JsonRequestBehavior.AllowGet);
        }


    }
}