using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class CarroController : Controller
    {
        //Simular o banco de dados
        private static List<Carro> _banco = new List<Carro>();

        //Exibir todos os carros registrados
        public IActionResult Index()
        {
            return View(_banco); //envia a lista de carros para a view
        }

        [HttpPost]
        public IActionResult Editar(Carro carro)
        {
            //Editar o carro na lista
            _banco[_banco.FindIndex(c => c.Codigo == carro.Codigo)] = carro;
            //Mandar uma mensagem de sucesso
            TempData["msg"] = "Carro atualizado!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }

        //Editar -> recebe o código do carro e abre um formulário com os dados preenchidos
        [HttpGet]
        public IActionResult Editar(int id)
        {
            //Pesquisar o carro do código informado e mandar para view
            var carro = _banco.Find(c => c.Codigo == id);
            return View(carro);
        }

        //Cadastrar um carro na lista e exibir uma mensagem de sucesso
        //Não permitir o reenvio do formulário após o cadastro
        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            carro.Codigo = _banco.Count + 1; //Adiciona um código para o carro Count = size()
            _banco.Add(carro);
            TempData["msg"] = "Carro registrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
