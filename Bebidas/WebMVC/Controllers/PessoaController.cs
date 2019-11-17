using Dados.DAO;
using Dados.Modelo;
using Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class PessoaController : Controller
    {
        PessoaRepositorio repositorio = new PessoaRepositorio();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pessoa model)
        {
           
            repositorio.Salvar(model);
            ViewBag.Mensagem = $"A pessoa {model.Nome} foi salva com Sucesso";
            ModelState.Clear();
            return View();

        }

        public ActionResult List()
        {

            List<Pessoa> listaPessoas = repositorio.ListarTodos();

            return View (listaPessoas);
        }
    }
}