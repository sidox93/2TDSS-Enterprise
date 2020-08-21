using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula02.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula02.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abrir o formulário de cadastro
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Acionado no submit do formulário
        public IActionResult Cadastrar(Produto produto)
        {
            //return Content(produto.Nome + " " + produto.Valor 
            //                            + " " + produto.Quantidade);
            //Enviar valores para a view
            ViewData["titulo"] = produto.Nome;
            ViewBag.prod = produto;

            //Sobrevive após um redirect
            TempData["msg"] = "Produto cadastrado!";
            //return RedirectToAction("Cadastrar");

            //Envia o objeto produto para a view
            return View(produto); 
        }

    }
}
