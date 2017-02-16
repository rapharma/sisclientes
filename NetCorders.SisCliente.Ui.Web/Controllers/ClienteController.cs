using WebApp.SisCliente.Ui.Web.Models;
using WebApp.SisCliente.Ui.Web.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.SisCliente.Ui.Web.Controllers
{
    /// <summary>
    /// Pra ter uma controller, ela:
    /// 1 -> Tem que herdar de Controller (já vem sozinho)
    /// 2 -> O sufixo precisa ser Controller
    /// </summary>
    public class ClienteController : Controller
    {
        // GET: Cliente
        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Quando não tem parametros na view, ele procura uma tela com o nome do ActionResult
            //Se eu colocar nome na view, posso mudar o ActionResult
            return View("Cadastrar");
        }

        //mvcpost
        [HttpPost]
        public ActionResult Cadastrar(clienteMOD model)
        {
            if (ModelState.IsValid)
            {
                using(var conexao = new Conexao())
                {
                    conexao.Cliente.Add(model);

                    conexao.SaveChanges();

                    return RedirectToAction("Listar");
                }
            }

            return View();
        }

        //mvcaction 
        //por padrao GET
        [HttpGet]
        public ActionResult Listar()
        {
            using (var conexao = new Conexao()) //resolve
            {
                var clientes = conexao.Cliente.ToList();
            return View("Listar", clientes);
            //return View(clientes);

            }
        }


    }
}