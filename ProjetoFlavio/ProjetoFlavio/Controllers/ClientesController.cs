using ProjetoFlavio.DAO;
using ProjetoFlavio.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        /// [Route("clientes/novo", Name = "NovosClientes")]
        public ActionResult Index()
        {

            var clientes = _clienteDao.Lista();
            return View(clientes);

        }


        public ActionResult Adicionar()
        {
            return View(new ViewModelClienteEndereco());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(ViewModelClienteEndereco viewCadastrado)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(viewCadastrado);
                }

                _clienteDao.Salva(viewCadastrado.Clientes);
                viewCadastrado.ClientesEnderecos.ClientesId = viewCadastrado.Clientes.ClienteId;
                _clienteEnderecoDao.Salva(viewCadastrado.ClientesEnderecos);

                return RedirectToAction("Index");


            }
            catch (Exception e)
            {
                TempData.Add("Erro", e.Message);
                return View(viewCadastrado);
            }

        }



        // [Route("clientes/{id}", Name = "EditarClientes")]
        public ActionResult Detalhes(int id)
        {


            try
            {
                ViewModelClienteEndereco viewModelClienteEndereco = new ViewModelClienteEndereco(_clienteEnderecoDao.BuscaPorClienteEndereco(id));
                return View(viewModelClienteEndereco);
            }
            catch (Exception e)
            {
                TempData.Add("Erro", e.Message);
                return RedirectToAction("Index");
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Detalhes(ViewModelClienteEndereco viewCadastrado)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return View(viewCadastrado);
                }

                _clienteDao.Atualiza(viewCadastrado.Clientes);
                viewCadastrado.ClientesEnderecos.ClientesId = viewCadastrado.Clientes.ClienteId;
                _clienteEnderecoDao.Atualiza(viewCadastrado.ClientesEnderecos);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                TempData.Add("Erro", e.Message);
                return View(viewCadastrado);
            }

           

        }

        //  [Route("busca/{id}", Name = "busca")]
        public JsonResult BuscaCliente(int id)
        {
            var retornoPesquisa = _clienteEnderecoDao.BuscaPorClienteEndereco(id);

            return Json(retornoPesquisa, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ValidaCPFCNPJ(string cpf)
        {
            var teste = new Collection<string>
            {
                "11111111",
                "55555555",
                ""

            };

            return Json(teste.All(x => string.Equals(x, cpf, StringComparison.CurrentCultureIgnoreCase)), JsonRequestBehavior.AllowGet);
        }


    }
}