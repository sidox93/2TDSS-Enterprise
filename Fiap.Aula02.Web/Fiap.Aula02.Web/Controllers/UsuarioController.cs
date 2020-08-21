using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula02.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula02.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            ViewData["msg"] = "Sucesso!";
            ViewBag.user = usuario;
            TempData["msg"] = "Usuário registrado!";
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
