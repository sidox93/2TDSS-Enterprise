using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public IActionResult Remover(int id)
        {
            //Remover o carro da lista através do index
            _banco.RemoveAt(_banco.FindIndex(c => c.Codigo == id));
            //Mensagem de sucesso
            TempData["msg"] = "Carro removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
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
            //Método que carrega o select de fabricantes
            CarregarFabricantes();
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
            CarregarFabricantes();
            return View();
        }

        private void CarregarFabricantes()
        {
            //Enviar os valores para carregar o select do fabricante
            List<string> lista = new List<string>();
            lista.Add("Ford");
            lista.Add("Fiat");
            lista.Add("Pegeout");
            lista.Add("Hyundai");

            ViewBag.fabricantes = new SelectList(lista);
        }
    }
}

